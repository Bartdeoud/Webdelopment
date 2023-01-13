import React, { Component } from "react";
import Alinea from "../Shared/Alinea";
import Hero2 from "../Shared/Hero2";

class VierNulVier extends Component {

    render () {
        return(
            <>
                <Hero2 tekst="404 page not found"/>

                <section className="contact">
                    <Alinea titel="De pagina bestaat niet" 
                    tekst="De pagina die u probeert te 
                    zoeken bestaat helaas niet." 
                    link ="/"
                    linknaam="Ga terug naar de home pagina."/>
                </section>
            </>
        );
    }
}

export default VierNulVier;