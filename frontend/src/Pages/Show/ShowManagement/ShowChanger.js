import axios from "axios";
import React, {useEffect, useState} from "react";
import { useNavigate, useLocation } from 'react-router-dom';
import Hero2 from "../../Shared/Hero2.js";

const ShowChanger = () => {
    const [genre, setGenre] = useState();
    const [genreApi, setGenreApi] = useState();
    const [genreNaam, setGenreNaam] = useState([]);

    const [zaal, setZaal] = useState([]);
    const [zaalApi, setZaalApi] = useState();
    const [zaalnaam, setZaalNaam] = useState([]);

    const [leeftijdsgroep, setLeeftijdsgroep] = useState([]);
    const [leeftijdsgroepApi, setLeeftijdsgroepApi] = useState([]);
    const [leeftijdsgroepNaam, setLeeftijdsgroepNaam] = useState([]);

    const navigate = useNavigate();
    const {state} = useLocation();
    const {
        shownr,
        TitelVoorstelling,
        LinkToImg,
    } = state;

    const titel = TitelVoorstelling + " aanpassen";

    const handleSubmit = async () => {
        console.log(genre, genreApi);
        handleOnSubmit();
        navigate('/ShowAanpassen');
    }

    useEffect(() => {
        // Loads all halls
        axios.get('https://localhost:7214/api/Zaal')
        .then(res => {
            console.log(res)
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
            console.log(res)
            setLeeftijdsgroep(res.data)
        })
        .catch(err =>{
            console.log(err)
        })

        // Loads genre of show
        axios.get('https://localhost:7214/api/Genre/Show/' + shownr)
        .then(res => {
            console.log(res)
            setGenreNaam(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    
        // Loads hall of show
        axios.get('https://localhost:7214/api/Zaal/Show/' + shownr)
        .then(res => {
            console.log(res)
            setZaalNaam(res.data)
        })
        .catch(err =>{
            console.log(err)
        })

        // Loads agegroup of show
        axios.get('https://localhost:7214/api/Leeftijdsgroep/Show/' + shownr)
        .then(res => {
            console.log(res)
            setLeeftijdsgroepNaam(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [shownr]);

    const handleOnSubmit = async () => {
        const NameChange = document.getElementById("NameChange").value;
        const ImageChange = document.getElementById("ImageChange").value;

        axios.put('https://localhost:7214/api/Show/' + shownr, {
            "shownr" : shownr,
            "afbeelding" : ImageChange,
            "naam" : NameChange,
            "zaal" : zaalApi,
            "genre" : 1,
            "leeftijdsgroep" : 2
        })
    }

    return (
        <>
            <Hero2 tekst={titel}/>

            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <p>Naam aanpassen</p>
                    <input type="text" id="NameChange" defaultValue={TitelVoorstelling}/>
                    <br/>

                    <p>Zaal aanpassen</p>
                    <select id="HallChange" onChange={(e)=>setZaalApi(e.target.value)}>
                        <option value="" disabled selected>Huidige zaal: {zaalnaam.naam}</option>
                        {zaal.map((zaal) => (
                            <option key={zaal.zaalnr} value={zaal.zaalnr}>{zaal.naam}</option>
                        ))}
                    </select>
                    <br/>

                    <p>Leeftijdsgroep aanpassen</p>
                    <select id="AgeChange" onChange={(e)=>setLeeftijdsgroepApi(e.target.value)}>
                        <option value="" disabled selected>Huidige leeftijdsgroep: {leeftijdsgroepNaam.naam}</option>
                        {leeftijdsgroep.map((leeftijdsgroep) => (
                            <option key={leeftijdsgroep.leeftijdsgroepid} value={leeftijdsgroep.leeftijdsgroepid}>{leeftijdsgroep.leeftijdsgroepid}</option>
                        ))}
                    </select>
                    <br/>

                    <p>Genre aanpassen</p>
                    <select id="GenreChange" onChange={(e)=>setGenreApi(e.target.value)}>
                        <option value="" disabled selected>Huidige genre: {genreNaam.naam}</option>
                        {/* {genre.map((genre) => (
                            <option key={genre.id} value={genre.id}>{genre.naam}</option>
                        ))} */}
                    </select>
                    <br/>
                    
                    <p>Afbeelding aanpassen</p>
                    <input type="text" id="ImageChange" defaultValue={LinkToImg} />
                    <br/>

                    <button className="btn" type="submit">aanpassen</button>
                </form>
            </section>
        </>
    );
}

export default ShowChanger;