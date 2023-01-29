import React, { useState } from "react";
import axios from "../../api/axios";
import Hero2 from "../Shared/Hero2";
import { useNavigate, useLocation } from 'react-router-dom';

const ZaalChanger = () => {

    const [naamX, setNaamX] = useState("");
    const [rang1, setRang1] = useState(0);
    const [rang2, setRang2] = useState(0);
    const [rang3, setRang3] = useState(0);
    const [rang4, setRang4] = useState(0);
    const [invalideplaatsen2, setInvalideplaatsen] = useState();

    const navigate = useNavigate();
    const {state} = useLocation();
    const {zaalnr, Zaalnaam, Rang1, Rang2, Rang3, Rang4, invalideplaatsen} = state;
    console.log (Zaalnaam, Rang1, Rang2, Rang3, Rang4, invalideplaatsen)

    const handleSubmit = async () => {
        handleOnSubmit();
        navigate('/ZaalAanpassen');
    }

    const handleOnSubmit = async () => {
        axios.put ('https://localhost:7214/api/Zaal/' + zaalnr, {
            "zaalnr": zaalnr,
            "naam": naamX,
            "rang1": rang1,
            "rang2": rang2,
            "rang3": rang3,
            "rang4": rang4,
            "invalideplaatsen": invalideplaatsen2
          })        
    }

    return (
        <>
            <Hero2 tekst="Zaal aanpassen"/>

            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <p>Naam</p>
                    <input type="text" defaultValue={Zaalnaam} onChange={(e)=>setNaamX(e.target.value)}/>
                    
                    <p>Aantal stoelen voor Rang 1</p>
                    <input type="number" defaultValue={Rang1} onChange={(e)=>setRang1(e.target.value)}/>
                    
                    <p>Aantal stoelen voor Rang 2</p>
                    <input type="number" defaultValue={Rang2} onChange={(e)=>setRang2(e.target.value)}/>
                    
                    <p>Aantal stoelen voor Rang 3</p>
                    <input type="number" defaultValue={Rang3} onChange={(e)=>setRang3(e.target.value)}/>
                    
                    <p>Aantal stoelen voor Rang 4</p>
                    <input type="number" defaultValue={Rang4} onChange={(e)=>setRang4(e.target.value)}/>
                    
                    <p>Aantal invalideplaatsen</p>
                    <input type="number" defaultValue={invalideplaatsen} onChange={(e)=>setInvalideplaatsen(e.target.value)}/>
                    <br/>
                    <button className="btn" type="submit">Aanpassen</button>
                </form>
            </section>
        </>
    )
}

export default ZaalChanger;