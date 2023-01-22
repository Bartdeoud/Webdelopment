import React, { useEffect } from 'react';
import Hero2 from '../Shared/Hero2';
import { useState } from "react";
import { DayPicker } from "react-day-picker";
import 'react-day-picker/dist/style.css';
import axios from 'axios';

const EvenementToevoegen = () => {
    const [day, setDay] = useState();
    const [shownaam, setNaam] = useState();
    const [showzaal, setZaal] = useState();
    const [leeftijd, setLeeftijd] = useState();
    const [showgenre, setGenre] = useState();
    const [shownummer, setShownr] = useState([]);

    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(day);
        console.log(shownaam);
        console.log(showzaal);
        console.log(leeftijd);
        console.log(showgenre);
        console.log(shownummer);
        handleOnSubmit();
    }

    useEffect(() => {
        axios.get("https://localhost:7214/api/Show/getLastShowID")
        .then(res => {
            console.log(res)
            setShownr(res.data+1)
        })
        .catch(err => {
            console.log(err)
        })
    }, []);

    let handleOnSubmit = async (e) => {
        e.preventDefault();
        try {
          let res = await fetch("https://localhost:7214/api/Show/ShowToevoegen", {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
            },
            body: JSON.stringify({
              id: 0,
              shownr: shownummer,
              afbeelding: "string",
              genre: showgenre,
              naam: shownaam,
              leeftijdsgroep: leeftijd,
              zaal: showzaal,
              beginTijd: day,
              eindTijd: day,
            }),
          });
          let data = await res.json();
          console.log(data);
          if (res.status === 200) {
            console.log("succes");
          } else { }
        } catch (err) {
          console.log(err);
        }
      }

    return (
        <>
            <Hero2 tekst="Show Toevoegen" />
            <section className="contact">
                <form>
                    <p>Naam evenement</p>
                    <input type="text" placeholder="Voer hier de naam van de show in" onChange={(e)=>setNaam(e.target.value)}/>

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

                    <p>Dagen</p>
                    <DayPicker
                        mode="single"
                        selected={day}
                        onSelect={setDay}
                    />

                    <button className="btn" onClick={handleSubmit}> Submit </button>
                </form>
            </section>   
        </>
    );
}

export default EvenementToevoegen;