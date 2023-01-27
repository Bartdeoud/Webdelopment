import React from "react";
import GetSessionId from "../../api/SessionId";
import Cookies from 'universal-cookie';

const redirect = () => {

    const cookies = new Cookies(document.cookies);

    const sessionId = GetSessionId(cookies.get("email"))
    const amount = cookies.get("toPay")

    return(
        <>
        <form id="redirectForm" method="post" action="https://fakepay.azurewebsites.net/">
        <input type="hidden" name="amount" value={amount}></input>
        <input type="hidden" name="url" value="https://localhost:7214/api/Pay"></input>
        <input type="hidden" name="reference" value={sessionId}></input>
        <button className="btn" type="onsubmit">Betaal!</button>
        </form>
        </>
    );
}

export default redirect;