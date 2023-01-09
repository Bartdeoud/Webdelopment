import React from "react";
import { useLocation } from 'react-router-dom';

const EvenementValues = () => {
    const {state} = useLocation();
    const {
        TitelVoorstelling,
        Artiest,
        zaal,
        datum,
        tijd,
        LinkToImg
    } = state;

    return (
        <section className="programmaBlock">
                <div class="evenementblock">
                <img src={LinkToImg} alt="Afbeelding evenement" width="100%" height="100%"></img>
                    <h1>
                        {TitelVoorstelling}<br/>
                        {Artiest}<br/>
                        {zaal}<br/>
                        {datum}<br/>
                        {tijd}<br/>
                    </h1>
                </div>
        </section>
    );
}

export default EvenementValues;