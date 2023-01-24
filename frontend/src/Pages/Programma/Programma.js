import React from "react";
import Hero2 from "../Shared/Hero2";
import ShowFetching from "../../api/ShowFetching";

const Programma = () => {
    return(
        <>
            <Hero2 tekst="Programma"/>
            <ShowFetching/>
        </>
    );
}

export default Programma;