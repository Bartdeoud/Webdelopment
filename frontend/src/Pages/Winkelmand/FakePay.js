import Cookies from 'universal-cookie';
import React from 'react';

const FakePay = (props) => {
    const cookies = new Cookies();
    
    cookies.set("toPay", props.bedrag)

    const setcookie = (value) =>{
        cookies.set("email", value);
    }

    return<>
    <form action={"/Redirect"}>
        <input name="email" type="email" placeholder="Voer hier uw email in" onChange={e => setcookie(e.target.value)}></input>
        <button className="btn" type="onsubmit">Betaal!</button>
    </form>
    </>
}

export default FakePay;