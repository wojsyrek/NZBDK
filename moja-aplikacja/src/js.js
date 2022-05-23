export default function Listeners() {
    document.getElementById('menu-toggle').addEventListener("click", () => {
        document.getElementById('sidebar').classList.add('active');
        document.getElementById('content-box').classList.add('active');
        document.getElementById('select-bar').classList.add('active');
    })
    document.getElementById('toggle-in').addEventListener("click", () => {
        document.getElementById('sidebar').classList.remove('active');
        document.getElementById('content-box').classList.remove('active');
        document.getElementById('select-bar').classList.remove('active');
    })
    document.getElementById('klz').addEventListener("click", () => {
        console.log('siema');
        if(document.getElementById('search-klz').classList.contains('active')) {
            document.getElementById('search-klz').classList.remove('active');
        }
        else document.getElementById('search-klz').classList.add('active');
    })
    document.getElementById('logins').addEventListener("click", () => {
        console.log('siema');
        if(document.getElementById('search-login').classList.contains('active')) {
            document.getElementById('search-login').classList.remove('active');
        }
        else document.getElementById('search-login').classList.add('active');
    })

  }

  