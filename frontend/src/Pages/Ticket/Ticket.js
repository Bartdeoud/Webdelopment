import React from "react";
import Hero2 from "../Shared/Hero2";

function getSucces(){
    const urlParams = new URLSearchParams(window.location.search);
    if(urlParams.get('succes') == "True"){
        return "Betaling gelukt"
    }
    return "Betaling mislukt"
}

const Ticket = () => {
    return(
        <>
            <Hero2 tekst={getSucces()}/>
        </>
    );
}

export default Ticket;