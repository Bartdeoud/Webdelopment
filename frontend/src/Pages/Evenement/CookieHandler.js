import Cookies from 'universal-cookie';

function setCookies() {
const cookies = new Cookies(document.cookies);
cookies.set(document.getElementById('titelvoorstelling').innerText, cookies.get("tempRang") + ";" + document.getElementById('NumberTickets').value,{ path: '/Winkelmand' });
}

export default setCookies