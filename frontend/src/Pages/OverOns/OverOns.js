import React, { Component } from "react";
import Alinea from "../Shared/Alinea";
import Hero2 from "../Shared/Hero2";

class OverOns extends Component {
    render () {
        return(
            <>
                <Hero2 tekst="Over ons"/>

                <section className="contact">
                    <Alinea titel="Wie wij zijn" tekst="<s>Wij zijn 4 studenten die een phishing website opgezet hebben voor een lokaal theater</s>Wij zijn het laaktheater! Wij verkopen kaartjes voor al uw favoriete shows"/>
                </section>
            </>
        );
    }
}

export default OverOns;