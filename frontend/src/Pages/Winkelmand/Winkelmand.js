import React from "react";
import Hero2 from "../Shared/Hero2";
import FakePay from "./FakePay";
import Alinea from "../Shared/Alinea";
import TicketBlok from "./TicketBlok";
import Cookies from 'universal-cookie';

const Winkelmand = () => {
    const showListNaam = [];
    const showListRang = [];
    const showListAantal = [];
    const showList = [];
    var totaaltickets = 0;

    try{
        var shows = document.cookie.split(";");
        shows.forEach(element => {
            var parts = element.split("=");
            var parts2 = parts[1].split("%3B")
            if (parts2[1] !== undefined){
                showListNaam.push(parts[0])
                showListRang.push(parts2[0])
                showListAantal.push(parts2[1])
                totaaltickets = totaaltickets + parseInt(parts2[1])
            }
        })   

        var ticketData = "";

        for (let i = 0; i < showListNaam.length; i++) {
            showList.push(<TicketBlok TitelVoorstelling={showListNaam[i]} rang={showListRang[i]} AantalTickets={showListAantal[i]}/>)
            ticketData += [showListNaam[i], showListRang[i], showListAantal[i],""];
        }

        const cookies = new Cookies(document.cookies);
        cookies.set("ticketData",ticketData)

        return(
            <>
                <Hero2 tekst="Winkelmand"/>
                <section className="contact">
                    <h3 className="title"> Totaal aantal tickets </h3>
                    <p> {totaaltickets} tickets voor €{totaaltickets * 10} </p>
                    <FakePay bedrag={totaaltickets * 10}/>
                    <br/>
                    <hr/>
                </section>
                {showList}
            </>
        )

    }catch{
        return(
            <>
                <Hero2 tekst="Winkelmand"/>
                <Alinea titel="Geen kaarten in winkelmand" link="/Programma" linknaam="Ga naar het programma om kaarten toe te voegen."/>
            </>
        );
    }
}

export default Winkelmand;