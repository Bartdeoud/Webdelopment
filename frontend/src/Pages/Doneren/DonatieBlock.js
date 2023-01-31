import React from "react";
import {useNavigate} from 'react-router-dom';

const DonatieBlock = (props) => {
    const {
        //shownr,
        TitelVoorstelling,
        LinkToImg
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
                        <br/>
                    </div>

                    <div id="bestel">
                        <br/>
                        <button onClick={()=>{navigate('/ReviewToevoegen', { state:props})}} className="btn">Review plaatsen</button>
                        <br/>
                    </div>
                </div>      
        </section>
    );
}

export default DonatieBlock;