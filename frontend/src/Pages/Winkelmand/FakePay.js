import React from "react";
import GetSessionId from "../../api/SessionId.js";

const FakePay = (props) => {
    return <form method="post" action="https://fakepay.azurewebsites.net/">
    <input type="hidden" name="amount" value={props.bedrag}></input>
    <input type="hidden" name="reference" value={GetSessionId()}></input>
    <input type="hidden" name="url" value="http://localhost:3000/Winkelmand"></input>
    <button className="btn" type="submit">Betaal!</button>
    </form>

}

export default FakePay;