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
                <div class="Evenement">
                    <img src={LinkToImg} alt="Afbeelding evenement" width="50%" height="50%"></img>
                        <p>
                        {TitelVoorstelling}<br/>
                        {Artiest}<br/>
                        {zaal}<br/>
                        {datum}<br/>
                        {tijd}<br/>
                        </p>
                </div>
        </section>
    );
}

export default EvenementValues;