import React, { Component } from "react";
import Alinea from "../Shared/Alinea";
import Hero2 from "../Shared/Hero2";

class OverOns extends Component {
    render () {
        return(
            <>
                <Hero2 tekst="Over ons"/>

                <Alinea titel="Over het Laaktheater" 
                    tekst="Het Laaktheater is een professioneel theatergezelschap 
                    dat zich richt op het opvoeren van toneelstukken voor een breed 
                    publiek. Ons doel is om mensen te entertainen en te inspireren 
                    door middel van onze voorstellingen. Wij werken met een team van 
                    professionele acteurs, regisseurs en technici om de hoogste 
                    kwaliteit te leveren. Onze voorstellingen worden opgevoerd in 
                    diverse theaters in de regio en zijn toegankelijk voor een breed 
                    publiek. Wij hopen u binnenkort te verwelkomen in ons theater!"/>
            </>
        );
    }
}

export default OverOns;