import React, { Component } from "react";
import EvenementBlock from "../Programma/EvenementBlock";
import Hero2 from "../Shared/Hero2";



class Contact extends Component {
    constructor(props) {
        super(props);
        this.state = {
            data: null,
        };
    }
    render () {
        return(
            <>
                <Hero2 tekst="Winkelmand"/>
                <EvenementBlock TitelVoorstelling="Titel Voorstelling" Artiest="artiest" zaal="zaal" datum="datum" tijd="tijd" LinkToImg="..\\assets\\image\\LaakZaal3.jpg"/>

                
            </>
        );
    }
}

export default Contact;