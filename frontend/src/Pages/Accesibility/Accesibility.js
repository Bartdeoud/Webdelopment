import React, { Component } from "react";
import Alinea from "../Shared/Alinea";
import Hero2 from "../Shared/Hero2";


class Accesibility extends Component {
    constructor(props) {
        super(props);
        this.state = {
            data: null,
        };
    }
    render () {
        return(
            <>
                <Hero2 tekst="Accesibility"/>

                <section className="contact">
                    <Alinea titel="Toegankelijkheid" tekst="Vind hier uw informatie over toegankelijkheid bij theater Laak."/>
                </section>
            </>
        );
    }
}

export default Accesibility;