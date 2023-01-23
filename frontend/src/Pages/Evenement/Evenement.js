import React from "react";
import EvenementValues from "./EvenementValues.js";
import GetSeats from "./Seats.js";
import setCookies from "./CookieHandler.js";

const Programma = () => {
    return(
        <div className="EvenementPagina">
            <EvenementValues/>
            <GetSeats/>
            <div>
            <label>
                Aantal kaartjes (0-9):
                <input type="text" id="NumberTickets"/>
            </label>
                <br/><br/>
                <button className="btn" type="onClick" onClick={() => {
                        setCookies()
                        window.location.href='/Winkelmand'
                }}>Bestel</button>
                <br/><br/>
            </div>
        </div>
    );
}

export default Programma;