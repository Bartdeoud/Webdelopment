import React from "react";

const FakePay = (props) => {
    return <form method="post" action="https://fakepay.azurewebsites.net/">
    <input type="hidden" name="amount" value={props.bedrag}></input>
    <input type="hidden" name="reference" value="65"></input>
    <input type="hidden" name="url" value="http://localhost:3000/Winkelmand"></input>
    <button className="btn" type="submit">Betaal!</button>
    </form>
}

export default FakePay;