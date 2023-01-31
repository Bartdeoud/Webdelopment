import React from "react";
import Hero2 from "../Shared/Hero2";
import Alinea from "../Shared/Alinea";
import Cookies from "universal-cookie";
import PoorPeoplePage from "./PoorPeoplePage";

const BegunstigersPortaal = () => {
    const cookies = new Cookies(document.cookies);

    if (cookies.get("roles") === undefined){
        return(
            <PoorPeoplePage />
        );
    }else if (cookies.get("roles")[0] === 'Donateur'){
        return(
            <>
                <Hero2 tekst="Begunstigers portaal" />
                <Alinea titel="Plaats reviews op uw favoriete shows."
                    tekst="Wilt u een review achterlaten op uw favoriete shows?"
                    link="/Review"
                    linknaam="Klik dan hier om een review te schrijven."/>          
            </>
        );
    }else{
        return(
            <PoorPeoplePage />
        );
    }
}

export default BegunstigersPortaal;