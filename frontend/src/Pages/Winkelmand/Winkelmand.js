import React from "react";
import Hero2 from "../Shared/Hero2";
import FakePay from "./FakePay";
import Alinea from "../Shared/Alinea";
import TicketBlok from "./TicketBlok";

const Winkelmand = () => {
    const showListNaam = [];
    const showListRang = [];
    const showListAantal = [];
    // let totaaltickets;

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
                // totaaltickets = totaaltickets + parts2[1]
            }
        })
        for (let i = 0; i < showListNaam.length; i++) {
            console.log("in show " + showListNaam[i] + " - " + showListRang[i] + " - " + showListAantal[i])
            return(
                <>
                    <Hero2 tekst="Winkelmand"/>
                    <TicketBlok TitelVoorstelling={showListNaam[i]} rang={showListRang[i]} AantalTickets={showListAantal[i]}/>
                    <TicketBlok TitelVoorstelling={showListNaam[i+1]} rang={showListRang[i+1]} AantalTickets={showListAantal[i+1]}/>
                    {/* {totaaltickets} */}
                    <FakePay/>
                </>
            )
        }
    }catch{
        console.log("No shows in cookie")
        return(
            <>
                <Hero2 tekst="Winkelmand"/>
    
                <section className="contact">
                    <Alinea titel="Geen kaarten in winkelmand" link="/Programma" linknaam="Ga naar het programma om kaarten toe te voegen."/>
                </section>
            </>
        );
    }
}

export default Winkelmand;