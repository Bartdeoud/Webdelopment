import React, { Component } from "react";
import Hero2 from "../Shared/Hero2";
import Evenement from "./Evenement.js";

class Programma extends Component {
    constructor(props) {
        super(props);
        this.state = {
            data: null,
        };
    }
    render () {
        return(
            <>
                <Hero2 tekst="Programma"/>
                <Evenement TitelVoorstelling="Titel Voorstelling" Artiest="artiest" zaal="zaal" LinkToEv="/voorstelling1" LinkToImg="..\\assets\\image\\LaakZaal3.jpg"/>
                <Evenement TitelVoorstelling="Titel Voorstelling 2" Artiest="artiest 2" zaal="zaal 2" LinkToEv="/voorstelling2" LinkToImg="..\\assets\\image\\LaakZaal2.jpg"/>
            </>
        );
    }
}

export default Programma;