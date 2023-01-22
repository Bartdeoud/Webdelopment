import React from "react";
import Hero from "./Hero";
import Alinea from "../Shared/Alinea";

const Home = () => {
    return(
        <>
            <Hero />
            
            <Alinea titel="Welkom bij het Laaktheater!" 
                tekst="Met trots presenteren wij onze nieuwe voorstellingenkalender 
                voor het komende seizoen. Na een moeilijke periode waarin we helaas 
                onze deuren moesten sluiten, zijn wij blij om aan te kondigen dat we 
                weer terug zijn en klaar om u te verwelkomen in ons theater."
                
                tekst2="Ons team heeft hard gewerkt om een gevarieerd programma samen te stellen, 
                met iets voor iedereen. Van klassieke toneelstukken tot moderne stukken 
                en muziekvoorstellingen. Wij zijn ervan overtuigd dat er voor iedereen wel 
                iets interessants tussen zit." />
        </>
    );
}


export default Home;
