import React, { useState } from "react";
import Hero2 from "../Shared/Hero2";

const Doneren = () => {
    const [bedrag,setbedrag] = useState()

    function hasToken(){
        return new URLSearchParams(window.location.search).get("token") != null;
    }
//bedrang en aantal hier in gooien
    if(!hasToken())
    return (
        <>
            <Hero2 tekst="Doneren"/>
            <form method="post" action={"https://ikdoneer.azurewebsites.net/Toegang?url=https://localhost:7214/api/Doneren?bedrag=" + bedrag}>
                <input id="bedrag" placeholder='Vul hier uw bedrag in' type="text" onChange={(e)=>setbedrag(e.target.value)}/>
                <button className="btn" type="onsubmit">Doneren</button>
            </form>
        </>
    );
    return(
        <>
            <Hero2 tekst="Doneren"/>
        </>
    )
}

export default Doneren;