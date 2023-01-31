import React, { useEffect, useState } from "react";
import setCookies from "./CookieHandler.js";
import { useLocation } from 'react-router-dom';
import axios from "axios";
import Option from "./Option.js";

const Show = () => {
    const [zaalX, setZaalX] = useState([]);
    const [zaal2, setZaal] = useState()
    const [genre2, setGenre] = useState()
    const [leeftijd2, setLeeftijd] = useState()
    const [max, setMax] = useState(1)

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

        axios.get('https://localhost:7214/api/Zaal/' + zaal,)
        .then(res => {
            console.log(res)
            setZaalX(res.data)
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
    
    const feetlicker = (e) => {
        e.preventDefault();
        const seats = [zaalX.rang1,zaalX.rang2,zaalX.rang3,zaalX.rang4]
        const rang = seats[document.getElementById("SelectedRang").value - 1];
        console.log(seats)
        setMax(rang)
        if (rang > 10){
            setMax(10)
        }
        if (max === 0 || max === null || max === undefined){
            setMax(1)
        }
    }

    return(
        <>
            <section className="programmaBlock">
                <div className="Evenement">
                    <img src={LinkToImg} alt="Afbeelding show" width="40%" height="40%"></img>
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
                    <h1>Kaartjes Bestellen</h1>
                    <br/>
                    <p>Rang:</p>
                    <select required onChange={feetlicker} id="SelectedRang">
                        <option value="" disabled selected hidden>Kies een rang</option>
                        <Option naam="Rang 1" value="1" rang={zaalX.rang1}/>
                        <Option naam="Rang 2" value="2" rang={zaalX.rang2}/>
                        <Option naam="Rang 3" value="3" rang={zaalX.rang3}/>
                        <Option naam="Rang 4" value="4" rang={zaalX.rang4}/>
                        <Option naam="Invalide plekken" value={zaalX.invalideplaatsen} rang={zaalX.invalideplaatsen}/>    
                    </select>

                    <p>Aantal tickets (1-{max}):</p>
                    <input type="number" required placeholder="Kies het aantal tickets" min={1} max={max} id="NumberTickets"/>

                    <button className="btn" type="submit">Bestel</button>
                </form>
                <br/>
                <hr/>
            </section>
        </>
    );
}

export default Show;