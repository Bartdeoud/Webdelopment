import React from "react";
import {useNavigate} from 'react-router-dom';

const ZaalBlock = (props) => {
    const {
        zaalnr,
        Zaalnaam,
        Rang1,
        Rang2,
        Rang3,
        Rang4,
        invalideplaatsen
    } = props

    const navigate = useNavigate();
    console.log (Rang1, Rang2, Rang3, Rang4, invalideplaatsen)

    return (
        <section className="programmaBlock">
                <div className="evenementblock">
                    <div>
                        <br/>
                        <p>{zaalnr}</p>
                    </div>
                    
                    <div>
                        <br/>
                        <h2>{Zaalnaam}</h2>
                    </div>

                    <div id="bestel">
                        <br/>
                        <button onClick={()=>{navigate('/ZaalChanger', { state:props})}} className="btn">Zaal aanpassen</button>
                        <br/>
                    </div>
                </div>      
        </section>
    );
}

export default ZaalBlock;