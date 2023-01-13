import React, { Component } from "react";
import Alinea from "../Shared/Alinea";
import Hero2 from "../Shared/Hero2";

class Account extends Component {
    render () {
        return(
            <>
                <Hero2 tekst="Mijn account"/>

                <section className="contact">
                    <Alinea titel="Inloggen" 
                    tekst="U bent momenteel nog niet ingelogd, log in om uw account te bekijken."
                    link="/Login"
                    linknaam="Klik hier om in te loggen"
                    tekst2="Heeft u nog geen account?"
                    link2="/Aanmaken"
                    linknaam2="Klik dan hier om een account aan te maken"/>

                </section>
            </>
        );
    }
}

export default Account;