import axios from "axios";
import React, {useEffect, useState} from "react";
import { useNavigate, useLocation } from 'react-router-dom';
import Hero2 from "../../Shared/Hero2.js";

const ShowChanger = () => {
    const [genre, setGenre] = useState([]);
    const [genreApi, setGenreApi] = useState();
    const [genreNaam, setGenreNaam] = useState([]);

    const [zaal, setZaal] = useState([]);
    const [zaalApi, setZaalApi] = useState();
    const [zaalnaam, setZaalNaam] = useState([]);

    const [leeftijdsgroep, setLeeftijdsgroep] = useState([]);
    const [leeftijdsgroepApi, setLeeftijdsgroepApi] = useState();
    const [leeftijdsgroepNaam, setLeeftijdsgroepNaam] = useState([]);

    const navigate = useNavigate();
    const {state} = useLocation();
    const {
        shownr,
        TitelVoorstelling,
        LinkToImg,
    } = state;

    const titel = TitelVoorstelling + " aanpassen";

    useEffect(() => {
        // Loads all halls
        axios.get('https://localhost:7214/api/Zaal')
        .then(res => {
            setZaal(res.data)
        })
        .catch(err =>{
            console.log(err)
        })

        // Loads all genres
        axios.get('https://localhost:7214/api/Genre')
        .then(res => {
            console.log(res)
            setGenre(res.data)
        })
        .catch(err =>{
            console.log(err)
        })

        // Loads all agegroups
        axios.get('https://localhost:7214/api/Leeftijdsgroep')
        .then(res => {
            setLeeftijdsgroep(res.data)
        })
        .catch(err =>{
            console.log(err)
        })

        // Loads genre of show
        axios.get('https://localhost:7214/api/Genre/Show/' + shownr)
        .then(res => {
            setGenreNaam(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    
        // Loads hall of show
        axios.get('https://localhost:7214/api/Zaal/Show/' + shownr)
        .then(res => {
            setZaalNaam(res.data)
        })
        .catch(err =>{
            console.log(err)
        })

        // Loads agegroup of show
        axios.get('https://localhost:7214/api/Leeftijdsgroep/Show/' + shownr)
        .then(res => {
            setLeeftijdsgroepNaam(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [shownr]);

    const handleSubmit = async () => {
        handleOnSubmit();
        navigate('/ShowAanpassen');
        window.location.reload(false);
    }

    const handleOnSubmit = async () => {
        const NameChange = document.getElementById("NameChange").value;
        const ImageChange = document.getElementById("ImageChange").value;

        axios.put('https://localhost:7214/api/Show/' + shownr, {
            "shownr" : shownr,
            "afbeelding" : ImageChange,
            "naam" : NameChange,
            "zaal" : zaalApi,
            "genre" : genreApi,
            "leeftijdsgroep" : leeftijdsgroepApi
        })
    }

    const handleDelete = async () => {
        axios.delete('https://localhost:7214/api/Show/' + shownr)
        .then(res => {
            console.log(res)
        })
        .catch(err =>{
            console.log(err)
        })
        navigate('/ShowAanpassen');
        window.location.reload(false);
    }

    return (
        <>
            <Hero2 tekst={titel}/>

            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <p>Naam aanpassen</p>
                    <input type="text" required id="NameChange" placeholder="Voer hier de naam van de show in" defaultValue={TitelVoorstelling}/>
                    <br/>

                    <p>Zaal aanpassen</p>
                    <select id="zaalchange" required onChange={(e)=>setZaalApi(e.target.value)}>
                        <option value="" disabled selected>Huidige zaal: {zaalnaam.naam}</option>
                        {zaal.map((zaal) => (
                            <option key={zaal.zaalnr} value={zaal.zaalnr}>{zaal.naam}</option>
                        ))}
                    </select>
                    <br/>

                    <p>Leeftijdsgroep aanpassen</p>
                    <select id="leeftijdchange" required onChange={(e)=>setLeeftijdsgroepApi(e.target.value)}>
                        <option value="" disabled selected>Huidige leeftijdsgroep: {leeftijdsgroepNaam.naam}</option>
                        {leeftijdsgroep.map((leeftijds) => (
                            <option key={leeftijds.leeftijdsgroepID} value={leeftijds.leeftijdsgroepID}>{leeftijds.naam}</option>
                        ))}
                    </select>
                    <br/>

                    <p>Genre aanpassen</p>
                    <select id="genrechange" required onChange={(e)=>setGenreApi(e.target.value)}>
                        <option value="" disabled selected>Huidige genre: {genreNaam.naam}</option>
                        {genre.map((genre) => (
                            <option key={genre.genreID} value={genre.genreID}>{genre.naam}</option>
                        ))}
                    </select>
                    <br/>
                    
                    <p>Afbeelding aanpassen</p>
                    <input type="text" placeholder="Plaats hier een afbeelding" id="ImageChange" defaultValue={LinkToImg} />
                    <br/>

                    <button className="btn" type="submit">aanpassen</button>
                </form>

                <br/><br/>
                <hr/>
                <form onSubmit={handleDelete}>
                    <p>Deze show verwijderen:</p>
                    <button className="btn" type="submit">Verwijderen</button>
                </form>
            </section>
        </>
    );
}

export default ShowChanger;