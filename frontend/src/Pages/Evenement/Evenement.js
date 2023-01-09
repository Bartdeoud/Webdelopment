import React, { Component } from "react";
import Hero2 from "../Shared/Hero2";
import EvenementValues from "./EvenementValues.js";

class Programma extends Component {
    render () {



        return(
            <>
                <Hero2 tekst="Evenement"/>
                <EvenementValues/>
            </>
        );
    }
}

export default Programma;