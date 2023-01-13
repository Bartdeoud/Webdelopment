import React, { Component } from "react";
import Alinea from "../Shared/Alinea";
import Hero2 from "../Shared/Hero2";

class Huren extends Component {
    render () {
        return(
            <>
                <Hero2 tekst="Huren"/>

                <section className="contact">
                    <Alinea titel="Dit is een kop" tekst="Dit is een tekst"/>
                </section>
            </>
        );
    }
}

export default Huren;