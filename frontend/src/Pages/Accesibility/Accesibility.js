import React from "react";
import Hero2 from "../Shared/Hero2";
import Lijst from "../Shared/Lijst";

const Accesibility = () => {
    return(
        <>
            <Hero2 tekst="Accesibility"/>

            <Lijst titel="Toegankelijkheid in het Laaktheater"
                tekst="Het Laaktheater is toegewijd aan het verstrekken van 
                een toegankelijke en inclusieve omgeving voor al onze bezoekers. 
                We bieden een aantal diensten aan om onze voorstellingen 
                toegankelijk te maken voor mensen met beperkingen, waaronder:"
                item1="Audiodescriptie: Dit is een service die tijdens de voorstelling een audiele beschrijving geeft van de visuele aspecten van de voorstelling, zoals kostuums, decors en lichteffecten."
                item2="Ondertiteling: Dit is een service die tijdens de voorstelling ondertitels geeft van het gesproken woord, zodat mensen met een gehoorprobleem de voorstelling kunnen volgen."
                item3="Toegankelijke parkeerplaatsen: We hebben gereserveerde parkeerplaatsen voor mensen met een beperking in de buurt van de ingang van het theater."
                item4="Rolstoeltoegankelijkheid: Ons theater is volledig rolstoeltoegankelijk, met speciaal gebouwde toiletten en een lift."
                tekst2="Als u specifieke behoeften heeft, neem dan gerust contact met ons op, zodat we u kunnen helpen bij het reserveren van kaarten en het gebruik van onze diensten."
            />
        </>
    );
}

export default Accesibility;