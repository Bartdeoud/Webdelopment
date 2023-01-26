import React from "react";
import GetSessionId from "../../api/SessionId.js";

function setSession(){
    var email = document.getElementById("email").value;
    document.getElementById("reference").value = GetSessionId(email)
}

const FakePay = (props) => {
    return <form method="post" action="https://fakepay.azurewebsites.net/">
    <input type="hidden" name="amount" value={props.bedrag}></input>
    <input type="hidden" id="reference" name="reference" value=""></input>
    <input type="hidden" name="url" value="https://localhost:7214/api/Pay"></input>
    <input type="email" id="email" name="email" defaultValue="Email"></input>
    <button className="btn" type="submit" onClick={setSession}>Betaal!</button>
    </form>
}

export default FakePay;