import React from "react";
import Hero2 from "../Shared/Hero2";
import FakePay from "./FakePay";
import Alinea from "../Shared/Alinea";
import TicketBlok from "./TicketBlok";

const Winkelmand = () => {
    const showListNaam = [];
    const showListRang = [];
    const showListAantal = [];
    const showList = [];
    var totaaltickets = 0;

    // Wil fail if there are no shows in the cookie
    try{
        var shows = document.cookie.split(";");
        shows.forEach(element => {
            var parts = element.split("=");
            var parts2 = parts[1].split("%3B")
            //parts1[0] = naam voorstelling, parts1[1] = rang, parts1[2] = aantal
            console.log("Buiten de show " +parts[0] + " - " + parts2[0] + " - " + parts2[1])
            // Filters the tempRang cookie
            if (parts2[1] !== undefined){
                showListNaam.push(parts[0])
                showListRang.push(parts2[0])
                showListAantal.push(parts2[1])
                totaaltickets = totaaltickets + parseInt(parts2[1])
            }
        })   
        for (let i = 0; i < showListNaam.length; i++) {
            console.log("in show " + showListNaam[i] + " - " + showListRang[i] + " - " + showListAantal[i])   
            showList.push(<TicketBlok TitelVoorstelling={showListNaam[i]} rang={showListRang[i]} AantalTickets={showListAantal[i]}/>)                    
        }
        return(
            <>
                <Hero2 tekst="Winkelmand"/>
                <section className="contact">
                    <h3 className="title"> Totaal aantal tickets </h3>
                    <p> {totaaltickets} tickets voor €{totaaltickets * 10}  </p>
                </section>
                <FakePay bedrag={totaaltickets * 10}/>
                <hr/>
                {showList}
            </>
        )

    }catch{
        console.log("No shows in cookie")
        return(
            <>
                <Hero2 tekst="Winkelmand"/>
    
                <Alinea titel="Geen kaarten in winkelmand" link="/Programma" linknaam="Ga naar het programma om kaarten toe te voegen."/>
            </>
        );
    }
}

export default Winkelmand;