import GetSessionId from "../../api/SessionId.js";
import React from 'react';

const FakePay = (props) => {
    return<>
    <form method="post" action="https://fakepay.azurewebsites.net/">
    <input type="hidden" name="amount" value={props.bedrag}></input>
    <input type="hidden" name="reference" value={GetSessionId()}></input>
    <input type="hidden" name="url" value="https://localhost:7214/api/Pay"></input>
    <button className="btn" type="onsubmit">Betaal!</button>
    </form>
    </>
}

export default FakePay;