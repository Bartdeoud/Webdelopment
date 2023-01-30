import axios from "axios";
import React, { useState, useEffect } from "react";
import {useNavigate} from 'react-router-dom';

const EvenementBlock = (props) => {
    const [zaal2, setZaal] = useState()
    const {
        TitelVoorstelling,
        zaal,
        datum,
        tijd,
        LinkToImg,
        genre,
        leeftijd
    } = props

    useEffect(() => {
        axios.get('https://localhost:7214/api/Zaal/' + zaal,)
        .then(res => {
            console.log(res)
            setZaal(res.data.naam)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [zaal]);

    console.log(leeftijd, genre)
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
                        <h3>{zaal2}</h3>
                    </div>

                    <div id="bestel">
                        <h3>{datum}</h3>
                        <h3>{tijd}</h3>
                        <button onClick={()=>{navigate('/Show', { state:props})}} className="btn">bestel</button>
                        <br/>
                    </div>
                </div>      
        </section>
    );
}

export default EvenementBlock;