import React from "react";
import Hero2 from "../Shared/Hero2";
import Alinea from "../Shared/Alinea";

const NoShow = () => {
    return (
        <>
            <Hero2 tekst="Geen voorstellingen gevonden"/>
            <Alinea titel="We konden helaas geen shows vinden"
                tekst="Herlaad de pagina of probeer het later opnieuw"/>
        </>
    )
}

export default NoShow;