import React from "react";
import {useNavigate} from 'react-router-dom';

const ShowBlock = (props) => {
    const {
        TitelVoorstelling,
        Artiest,
        zaal,
        datum,
        tijd,
        LinkToImg,
        leeftijdsgroep,
        genre
    } = props

    const navigate = useNavigate();

    return (
        <section className="programmaBlock">
                <div className="evenementblock">
                    <div>
                        <img src={LinkToImg} alt="Afbeelding evenement" width="100%" height="100%"></img>
                    </div>
                    
                    <div>
                        <br/>
                        <h2>{TitelVoorstelling}</h2>
                    </div>

                    <div id="bestel">
                        <h3>{datum}</h3>
                        <h3>{tijd}</h3>                        
                        <button onClick={()=>{navigate('/ShowChanger', { state:props})}} className="btn">Show aanpassen</button>
                        <br/>
                    </div>
                </div>      
        </section>
    );
}

export default ShowBlock;