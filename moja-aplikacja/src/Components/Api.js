export function GetSegments() {
    return fetch("https://localhost:7138/Api/Segment/GetAll")
      .then((res) => res.json())   
  }

export function GetSygnatures(segment) {
    console.log(segment);
    return fetch("https://localhost:7138/Api/Sygnature/GetSpecific", {
      method: "POST",
      body: JSON.stringify(segment),
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => res.json());
  }

  // GetVariants(sygnature) {
  //   fetch("https://localhost:7138/Api/Variant/GetSpecific", {
  //     method: "POST",
  //     body: JSON.stringify(sygnature),
  //     headers: {
  //       "Content-Type": "application/json",
  //     },
  //   })
  //     .then((res) => res.json())
  //     .then((json) => this.setState({ variants: json }));
  // }

  // GetFields(variant) {
  //   console.log(variant);
  //   fetch("https://localhost:7138/Api/Field/GetSpecific", {
  //     method: "POST",
  //     body: JSON.stringify(variant),
  //     headers: {
  //       "Content-Type": "application/json",
  //     },
  //   })
  //     .then((res) => res.json())
  //     .then((json) => this.setState({ fields: json }));
  // }