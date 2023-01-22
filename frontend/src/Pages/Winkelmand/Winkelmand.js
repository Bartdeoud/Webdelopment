import React from "react";
import Hero2 from "../Shared/Hero2";
import FakePay from "./FakePay";
import GetEvenement from "../../api/FetchWinkelmand.js";

const Winkelmand = () => {

    console.log(document.cookie);
    
    var shows = document.cookie.split(";");


    const addBlock = () =>{

    }

    return(
        <>
            <Hero2 tekst="Winkelmand"/>
            {
                    shows.forEach(element => {
                        var parts = element.split("=");
                        var parts2 = parts[1].split("%3B")
                        console.log(parts[0]);
                        GetEvenement(parts[0],parts2[0],parts2[1])
                    })
            }
            <FakePay/>
        </>
    );
}

export default Winkelmand;