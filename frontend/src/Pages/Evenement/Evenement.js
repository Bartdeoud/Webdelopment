import React from "react";
import EvenementValues from "./EvenementValues.js";
import GetSeats from "./Seats.js";
import setCookies from "./CookieHandler.js";

const Programma = () => {
    return(
        <>
            <EvenementValues/>
            
            <section className="contact">
                <GetSeats/>
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

export default Programma;