import React from "react";
import Hero2 from "../Shared/Hero2";
import FakePay from "./FakePay";
import GetEvenement from "../../api/FetchWinkelmand.js";
import EvenementValues from "../Evenement/EvenementValues";

const Winkelmand = () => {
    const showList = [];

    // Wil fail if there are no shows in the cookie
    try{
        var shows = document.cookie.split(";");
        shows.forEach(element => {
            var parts = element.split("=");
            var parts2 = parts[1].split("%3B")
            console.log(parts[0] + "-" + parts2[0] + "-" + parts2[1])
            // Filters the tempRang cookie
            if (parts2[1] !== undefined){
                console.log(parts[0])
                showList.push(GetEvenement(parts[0],parts2[0],parts2[1]))
            }
        })
    }catch{
        showList.push(<h2>Geen kaarten in winkelmand</h2>)
        console.log("No shows in cookie")
    }

    return(
        <>
            <Hero2 tekst="Winkelmand"/>

            <section className="contact">
                {showList}
            </section>

            <FakePay/>
        </>
    );
}

export default Winkelmand;