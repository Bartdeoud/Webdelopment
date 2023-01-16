import EvenementBlock from "../Programma/EvenementBlock";
import React from "react";
import Alinea from "../Shared/Alinea";
import Hero2 from "../Shared/Hero2";
import { useState } from "react";

const Winkelmand = () => {
    const [totaal, setTotaal] = useState("");

    let handleSubmit = () =>{
        fetch('https://fakepay.azurewebsites.net/', {
            method: 'POST',
            headers:{
              'Content-Type': 'application/x-www-form-urlencoded'
            },    
            body: new URLSearchParams({
                'amount': totaal,
                'reference': 'Betaal',
                'url': 'www.google.com'
            })
        });
    }

    return(
        <>
            <Hero2 tekst="Winkelmand"/>
            <section className="contact">
                <Alinea titel="Dit is een kop" tekst="Dit is een tekst"/>
            </section>

            <form onSubmit={handleSubmit}>
                <input type="number" placeholder="Totaal" onChange={(e) => setTotaal(e.target.value)} />
                <input type="submit" value="Submit" />
            </form>
        </>
    );
}

export default Winkelmand;