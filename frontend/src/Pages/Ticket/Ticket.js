import React, { useEffect } from "react";
import Alinea from "../Shared/Alinea";
import Hero2 from "../Shared/Hero2";

const Ticket = () => {
    const urlParams = new URLSearchParams(window.location.search);

    useEffect(() => {
    }, []);

    if(urlParams.get('succes') === "True"){
        return(
            <>
                <Hero2 tekst="Betaling gelukt"/>
                <Alinea titel="De betaling is succesvol verwerkt"
                tekst="Alle gegevens zijn opgeslagen."/>
            </>
        );
    }else{
        return(
            <>
                <Hero2 tekst="Betaling mislukt"/>
                <Alinea titel="De betaling is onverwachts foutgegaan "
                tekst="Controleer alle ingevoerde gegevens en probeer het opnieuw. 
                    Als deze fout zich blijft voortdoen neem dan contact met ons op."/>
            </>
        );
    }
}

export default Ticket;