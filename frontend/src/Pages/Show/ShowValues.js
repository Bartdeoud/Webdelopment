import React from "react";
import { useLocation } from 'react-router-dom';

const ShowValues = () => {
    const {state} = useLocation();
    const {
        TitelVoorstelling,
        zaal,
        datum,
        tijd,
        LinkToImg
    } = state;

    return (
        <section className="programmaBlock">
            <div className="Evenement">
                <img src={LinkToImg} alt="Afbeelding evenement" width="50%" height="50%"></img>
                    <p>
                        <h2 id="titelvoorstelling">{TitelVoorstelling}</h2>
                        {zaal}<br/>
                        {datum}<br/>
                        {tijd}<br/>
                    </p>
            </div>
        </section>
    );
}

export default ShowValues;