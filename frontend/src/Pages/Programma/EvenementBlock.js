import React from "react";
import {useNavigate} from 'react-router-dom';
import DataFetching from "../../DataFetching.js";

const EvenementBlock = (props) => {
    const {
        TitelVoorstelling,
        Artiest,
        zaal,
        datum,
        tijd,
        LinkToImg
    } = props

    const navigate = useNavigate();

    return (
        <section className="programmaBlock">
                <div class="evenementblock">
                    <div>
                        <img src={LinkToImg} alt="Afbeelding evenement" width="100%" height="100%"></img>
                    </div>
                    <div>
                        <DataFetching/>
                        <h2>{TitelVoorstelling}</h2>
                        <br></br>
                        <h3>{Artiest}</h3>
                        <h3>{zaal}</h3>
                    </div>

                    <div id="bestel">
                        <h3>{datum}</h3>
                        <h3>{tijd}</h3>
                        <br/>
                        <button onClick={()=>{navigate('/Evenement', { state:props})}} class="btn">bestel</button>
                    </div>
                </div>
                
        </section>
    );
}

export default EvenementBlock;