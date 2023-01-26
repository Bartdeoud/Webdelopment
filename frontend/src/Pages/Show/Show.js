import React from "react";
import ShowValues from "./ShowValues.js";
import Seats from "./Seats.js";
import setCookies from "./CookieHandler.js";

const Show = () => {
    return(
        <>
            <ShowValues/>
            
            <section className="contact">
                <Seats/>
                <br/>

                <p>Aantal kaartjes (1-9):</p>
                <input type="text" id="NumberTickets"/>
                <br/>

                <button className="btn" type="onClick" onClick={() => {
                    setCookies()
                    window.location.href='/Winkelmand'
                }}>Bestel</button>
                <br/>
                <hr/>
            </section>
        </>
    );
}

export default Show;