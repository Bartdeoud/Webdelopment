import React, { useState, useEffect } from "react";
import axios from "../../api/axios";
import Hero2 from "../Shared/Hero2";
import { useNavigate, useLocation } from 'react-router-dom';

const ZaalChanger = () => {
    const [zaalSelect, setZaalSelect] = useState([]);

    const [naamX, setNaamX] = useState("");
    const [rang1, setRang1] = useState(0);
    const [rang2, setRang2] = useState(0);
    const [rang3, setRang3] = useState(0);
    const [rang4, setRang4] = useState(0);
    const [invalideplaatsen, setInvalideplaatsen] = useState();

    const navigate = useNavigate();
    const {state} = useLocation();
    const {zaalnr} = state;

    useEffect(() => {
        axios.get('https://localhost:7214/api/Zaal/' + zaalnr)
        .then(res => {
            setZaalSelect(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);

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
            "invalideplaatsen": invalideplaatsen
          })        
    }

    return (
        <>
            <Hero2 tekst="Zaal aanpassen"/>

            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <p>Naam</p>
                    <input type="text" defaultValue={zaalSelect[1]} onChange={(e)=>setNaamX(e.target.value)}/>
                    
                    <p>Aantal stoelen voor Rang 1</p>
                    <input type="number" onChange={(e)=>setRang1(e.target.value)}/>
                    
                    <p>Aantal stoelen voor Rang 2</p>
                    <input type="number" onChange={(e)=>setRang2(e.target.value)}/>
                    
                    <p>Aantal stoelen voor Rang 3</p>
                    <input type="number" onChange={(e)=>setRang3(e.target.value)}/>
                    
                    <p>Aantal stoelen voor Rang 4</p>
                    <input type="number" onChange={(e)=>setRang4(e.target.value)}/>
                    
                    <p>Aantal invalideplaatsen</p>
                    <input type="number" onChange={(e)=>setInvalideplaatsen(e.target.value)}/>
                    <br/>
                    <button className="btn" type="submit">Aanpassen</button>
                </form>
            </section>
        </>
    )
}

export default ZaalChanger;