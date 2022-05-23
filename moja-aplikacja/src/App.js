import "./App.css";
import React from "react";
import "../node_modules/bootstrap/dist/css/bootstrap.css";
import "../node_modules/bootstrap/dist/css/bootstrap.min.css";
import "../node_modules/bootstrap/dist/js/bootstrap.js";
import "../node_modules/bootstrap-icons/font/bootstrap-icons.css";
import Listeners from "./js";
import { GetSegments } from "./Components/Api";
import { GetSygnatures } from "./Components/Api";
import { get } from "mongoose";

export class App extends React.Component {
  state = {
    segments: [],
    sygnatures: [],
    variants: {},
    fields: {},
    currentSegment: null,
  };

  componentWillUnmount() {
    Listeners();
  }
  componentDidMount() {
    GetSegments().then((json) => this.setState({ segments: json }));
  }
  getSelectedSygnature() {
    this.setState(
      { currentSegment: document.getElementById("select-1").value },
      () => {
        GetSygnatures(
          this.state.segments.find((x) => x.name === this.state.currentSegment)
        ).then((json) => this.setState({ sygnatures: json }));
      }
    );
  }

  render() {
    return (
      <div className="container-fluid h-100">
        <div className="row h-100">
          <i
            className="d-block bi bi-text-right position-fixed"
            id="toggle-in"
          ></i>
          <div
            className="d-flex flex-column col-md-2 h-100 shadow position-fixed"
            id="sidebar"
          >
            <div className="sidebar-header pt-3">
              <h3 className="text-light float-end text-end h5 d-inline-flex">
                <i className="d-block bi bi-text-right" id="menu-toggle"></i>
              </h3>
            </div>
            <hr></hr>
            <ul className="list-unstyled">
              <li className="d-block text-center text-md-start" id="policies">
                <a className="text-white text-decoration-none text-responsive">
                  <i className="bi bi-file-spreadsheet"></i>Polisy
                </a>
              </li>
              <li className="d-block text-center text-md-start" id="procedures">
                <a className="text-white text-decoration-none text-responsive">
                  <i className="bi bi-file-earmark-font"></i>Procedury
                </a>
              </li>
              <li className="d-block text-center text-md-start" id="klz">
                <a className="text-white text-decoration-none text-responsive">
                  <i className="bi bi-paperclip"></i>Klauzule
                </a>
              </li>

              <div className="bg-light search-field" id="search-klz">
                <input
                  className="w-100"
                  placeholder="Wyszukaj klauzule"
                ></input>
                <a></a>
              </div>
              <hr></hr>
              <li className="d-block text-center text-md-start" id="contacts">
                <a className="text-white text-decoration-none text-responsive">
                  <i className="bi bi-mailbox"></i>Kontakty
                </a>
              </li>
              <li className="d-block text-center text-md-start" id="logins">
                <a className="text-white text-decoration-none text-responsive">
                  <i className="bi bi-file-person p"></i>Loginy
                </a>
              </li>
              <div className="bg-light search-field" id="search-login">
                <input
                  className="w-100"
                  placeholder="Wyszukaj Login"
                ></input>

                <a></a>
              </div>
              <hr></hr>
              <li className="d-block text-center text-md-start" id="updates">
                <a className="text-white text-decoration-none text-responsive">
                  <i className="bi bi-megaphone"></i>Aktualności
                </a>
              </li>
            </ul>
          </div>
          <div
            className="d-flex col-lg-10 h-100 bg-gradient"
            id="content-box"
          >
            <div className="shadow" id="select-bar">
              <select
                defaultValue={"0"}
                id="select-1"
                onChange={() => this.getSelectedSygnature()}
                className="form-select"
              >
                <option value="0" disabled hidden>
                  Segment
                </option>
                {this.state.segments.map((o) => {
                  return (
                    <option key={o.id + o.name} id={o.id}>
                      {o.name}
                    </option>
                  );
                })}
              </select>
              <select defaultValue={"0"} id="select-2" className="form-select">
                <option value="0" disabled hidden>
                  Sygnatura
                </option>
                {this.state.sygnatures.map((o) => {
                  return (
                    <option key={o.id + o.name} id={o.id}>
                      {o.name}
                    </option>
                  );
                })}
              </select>
              <select defaultValue={"0"} className="form-select">
                <option value="0" disabled hidden>
                  Wariant
                </option>
                <option value="1">One</option>
                <option value="2">Two</option>
                <option value="3">Three</option>//
              </select>
            </div>
          </div>
        </div>
        {/* <div className="pulsating-circle"></div> */}
      </div>
    );
  }
}

export default App;
