import React, { Component } from "react";
import Hero2 from "../Shared/Hero2";
import EvenementBlock from "./EvenementBlock.js";

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
                <EvenementBlock TitelVoorstelling="Titel Voorstelling" Artiest="artiest" zaal="zaal" datum="datum" tijd="tijd" LinkToImg="..\\assets\\image\\LaakZaal3.jpg"/>
                <EvenementBlock TitelVoorstelling="Titel Voorstelling 2" Artiest="artiest 2" zaal="zaal 2" datum="datum 2" tijd="tijd 2" LinkToImg="..\\assets\\image\\LaakZaal2.jpg"/>
            </>
        );
    }
}

export default Programma;