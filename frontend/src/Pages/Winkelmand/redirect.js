import React from "react";
import GetSessionId from "../../api/SessionId";
import Cookies from 'universal-cookie';
import Alinea from "../Shared/Alinea";

const redirect = () => {
    const checkForm = () => {
        // eslint-disable-next-line
        if(document.getElementById('amount') != undefined & document.getElementById('reference') != undefined)
        document.getElementById("redirectForm").submit();
    }

    const cookies = new Cookies(document.cookies);

    const sessionId = GetSessionId(cookies.get("email"), cookies.get("ticketData"))
    const amount = cookies.get("toPay")

    return(
        <>
        <Alinea tekst="Redirecting..."></Alinea>
        <form id="redirectForm" method="post" action="https://fakepay.azurewebsites.net/">
        <input type="hidden" id="amount" name="amount" value={amount}></input>
        <input type="hidden" name="url" value="https://localhost:7214/api/Pay"/>
        <input type="hidden" id="reference" name="reference" value={sessionId} onChange={checkForm()}></input>
        </form>
        </>
    );
}

export default redirect;