import React from 'react';
import Hero2 from '../Shared/Hero2';
import { useState } from "react";
// import { DayPicker } from "react-day-picker";
import 'react-day-picker/dist/style.css';

const EvenementToevoegen = (props) => {
    // const [days, setDays] = useState();
    const [naam, setNaam] = useState();
    const [zaal, setZaal] = useState();
    const [leeftijd, setLeeftijd] = useState();
    const [genre, setGenre] = useState();

    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(naam);
        console.log(zaal);
        // console.log(days);
        console.log(leeftijd);
        console.log(genre);
        handleOnSubmit();
    }

    const handleOnSubmit = async (order) => {
        console.log ("handleOnSubmit");
        await fetch(URL, {
            method: 'POST',
            headers:{
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
            // body: 
        })
    }

    return (
        <>
            <Hero2 tekst="Evenement Toevoegen" />
            <section className="contact">
                <form>
                    <p>Naam evenement</p>
                    <input type="text"  required pattern=".*\S+.*" placeholder="Voer hier de naam van de show in" onChange={(e)=>setNaam(e.target.value)}/>

                    <p>Zaal</p>
                    <select required="required"  onChange={(e)=>setZaal(e.target.value)}>
                        <option value="" disabled selected>Selecteer een zaal</option>
                        <option value="zaal1">Zaal 1</option>
                        <option value="zaal2">Zaal 2</option>
                        <option value="zaal3">Zaal 3</option>
                        <option value="zaal4">Zaal 4</option>
                    </select>

                    <p>Leeftijdsgroep</p>
                    <select required="required" onChange={(e)=>setLeeftijd(e.target.value)}>
                        <option value="" disabled selected>Selecteer een leeftijdsgroep</option>
                        <option value="All">Alle leeftijden</option>
                        <option value="Onder18">Onder de 18</option>
                        <option value="18tot65">18 tot 65</option>
                        <option value="65plus">65+</option>
                    </select> 

                    <p>Genre</p>
                    <select required="required" onChange={(e)=>setGenre(e.target.value)}>
                    <   option value="" disabled selected>Selecteer een genre</option>
                        <option value="Comedy">Comedy</option>
                        <option value="Dance">Dance</option>
                        <option value="Drama">Drama</option>
                        <option value="Film">Film</option>
                        <option value="Klassiek">Klassiek</option>
                        <option value="Muziek">Muziek</option>
                        <option value="Musical">Musical</option>
                        <option value="Opera">Opera</option>
                    </select>

                    <br/>

                    {/* <p>Dagen</p>
                    <DayPicker
                        mode="multiple"
                        min={1}
                        selected={days}
                        onSelect={setDays}
                    /> */}

                    <button className="btn" onClick={handleSubmit}> Submit </button>
                </form>
            </section>   
        </>
    );
}

export default EvenementToevoegen;