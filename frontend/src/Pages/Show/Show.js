import React, { useEffect, useState } from "react";
import setCookies from "./CookieHandler.js";
import { useLocation } from 'react-router-dom';
import axios from "axios";

const Show = () => {
    const [zaal2, setZaal] = useState()
    const [genre2, setGenre] = useState()
    const [leeftijd2, setLeeftijd] = useState()

    const {state} = useLocation();
    const {
        TitelVoorstelling,
        zaal,
        datum,
        tijd,
        LinkToImg,
        genre,
        leeftijd
    } = state

    useEffect(() => {
        axios.get('https://localhost:7214/api/Zaal/' + zaal,)
        .then(res => {
            console.log(res)
            setZaal(res.data.naam)
        })
        .catch(err =>{
            console.log(err)
        })

        axios.get('https://localhost:7214/api/Genre/' + genre,)
        .then(res => {
            console.log(res)
            setGenre(res.data.naam)
        })
        .catch(err =>{
            console.log(err)
        })
        
        axios.get('https://localhost:7214/api/LeeftijdsGroep/' + leeftijd,)
        .then(res => {
            console.log(res)
            setLeeftijd(res.data.naam)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [zaal, genre, leeftijd]);

    const handleSubmit = (e) => {
        e.preventDefault();
        setCookies(TitelVoorstelling);
        window.location.href='/Winkelmand';
    }

    return(
        <>
            <section className="programmaBlock">
                <div className="Evenement">
                    <img src={LinkToImg} alt="Afbeelding evenement" width="40%" height="40%"></img>
                        <h1>{TitelVoorstelling} &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</h1>
                        <p>
                            {zaal2}<br/>
                            {datum}<br/>
                            {tijd}<br/>

                        </p>
                </div>
                Genre: {genre2}<br/>
                Leeftijdscategorie: {leeftijd2}<br/> 
            </section>
            
            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <h1>Bestel kaartjes</h1>
                    <br/>
                    <p>Rang:</p>
                    <select required id="SelectedRang">
                        <option value="" disabled selected hidden>Kies een rang</option>
                        <option value="Rang 1">Rang 1</option>
                        <option value="Rang 2">Rang 2</option>
                        <option value="Rang 3">Rang 3</option>
                        <option value="Rang 4">Rang 4</option>
                        <option value="Rang 5">Invalide plaatsen</option>
                    </select>

                    <p>Aantal tickets (1-10):</p>
                    <input type="number" placeholder="Kies het aantal tickets" min={1} max={10} id="NumberTickets"/>

                    <button className="btn" type="submit">Bestel</button>
                </form>
                

                <br/>
                <hr/>
                <button className="btn" type="onClick" onClick={handleSubmit}>Bestel</button>
                <br/>
                <hr/>
            </section>
        </>
    );
}

export default Show;