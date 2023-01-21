import React, { Component } from "react";
import Hero2 from "../Shared/Hero2";
import Lijst from "../Shared/Lijst";

class Voorwaarden extends Component {
    constructor(props) {
        super(props);
        this.state = {
            data: null,
        };
    }
    render () {
        return(
            <>
                <Hero2 tekst="Algemene voorwaarden"/>

                <Lijst titel="Algemene voorwaarden van het Laaktheater"
                    item1="Toepasselijkheid: Deze algemene voorwaarden zijn van toepassing op alle tickets, reserveringen en verkoop van kaarten door het Laaktheater."
                    item2="Prijzen en betaling: De prijzen van de kaarten zijn inclusief BTW en andere heffingen. Betaling dient plaats te vinden bij het reserveren van kaarten via onze website of bij ons kantoor."
                    item3="Annuleringen en wijzigingen: Annuleringen of wijzigingen van reserveringen dienen schriftelijk of per e-mail te worden gemeld aan het Laaktheater. Annuleringen tot 24 uur voor de voorstelling zullen worden terugbetaald, met uitzondering van administratiekosten."
                    item4="Toegang tot de voorstelling: Het Laaktheater behoudt zich het recht voor om toegang te weigeren aan bezoekers die zich niet houden aan de huisregels of zich onbehoorlijk gedragen."
                    item5="Gebruik van opnamemateriaal: Het is verboden om foto's of video's te maken tijdens de voorstellingen zonder toestemming van het Laaktheater."
                    item6="Aansprakelijkheid: Het Laaktheater is niet aansprakelijk voor verlies of beschadiging van eigendommen van bezoekers of voor enige andere schade die voortvloeit uit het bezoek aan ons theater."
                    tekst2="Wij wensen u een prettig bezoek toe!"
                />
            </>
        );
    }
}

export default Voorwaarden;