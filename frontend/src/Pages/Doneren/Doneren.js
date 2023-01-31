import React from "react";
import Hero2 from "../Shared/Hero2";

const Doneren = () => {
    return(
        <>
            <Hero2 tekst="Doneren"/>
            <form method="post" action="https://ikdoneer.azurewebsites.net/Toegang?url=https://localhost:7214/api/Doneren">
            <button className="btn" type="onsubmit">Doneren</button>
            </form>
        </>
    );
}

export default Doneren;