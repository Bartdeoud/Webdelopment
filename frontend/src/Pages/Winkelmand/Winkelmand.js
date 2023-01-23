import React from "react";
import Hero2 from "../Shared/Hero2";
import FakePay from "./FakePay";
import GetEvenement from "../../api/FetchWinkelmand.js";

const Winkelmand = () => {
    const showList = [];
    var shows = document.cookie.split(";");
    // {
    //     showList.push("Test")
    // }

    {
        shows.forEach(element => {
            var parts = element.split("=");
            var parts2 = parts[1].split("%3B")
            console.log(parts[0] + "-" + parts2[0] + "-" + parts2[1])
            showList.push(GetEvenement(parts[0],parts2[0],parts2[1]))
        })
    } 
    return(
        <>
            <Hero2 tekst="Winkelmand"/>
            {showList}
            <FakePay/>
        </>
    );
}

export default Winkelmand;