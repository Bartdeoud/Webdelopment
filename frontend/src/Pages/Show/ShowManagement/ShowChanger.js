import axios from "axios";
import React, {useEffect, useState} from "react";
import { useNavigate, useLocation } from 'react-router-dom';
import Hero2 from "../../Shared/Hero2.js";

const ShowChanger = () => {
    const [genre2, setGenre2] = useState([]);
    const [genre, setGenre] = useState();
    const [zaal2, setZaal2] = useState([]);
    const [zaal, setZaal] = useState([]);
    const [leeftijdsgroep, setLeeftijdsgroep] = useState([]);
    const [leeftijdsgroep2, setLeeftijdsgroep2] = useState([]);

    const {state} = useLocation();
    const {
        shownr,
        TitelVoorstelling,
        LinkToImg,
    } = state;

    const navigate = useNavigate();
    const titel = TitelVoorstelling + " aanpassen";

    const handleSubmit = async () => {
        handleOnSubmit();
        navigate('/ShowAanpassen');
    }

    // Loads all genres
    useEffect(() => {
        axios.get('https://localhost:7214/api/Genre')
        .then(res => {
            console.log(res)
            setGenre(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);

    // Loads all halls
    useEffect(() => {
        axios.get('https://localhost:7214/api/Zaal')
        .then(res => {
            console.log(res)
            setZaal(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);

    // Loads all agegroups
    useEffect(() => {
        axios.get('https://localhost:7214/api/Leeftijdsgroep')
        .then(res => {
            console.log(res)
            setLeeftijdsgroep(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    // eslint-disable-next-line react-hooks/exhaustive-deps
    }, []);

    // Loads genre of show
    useEffect(() => {
        axios.get('https://localhost:7214/api/Genre/Show/' + shownr)
        .then(res => {
            console.log(res)
            setGenre2(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [shownr]);

    // Loads hall of show
    useEffect(() => {
        axios.get('https://localhost:7214/api/Zaal/Show/' + shownr)
        .then(res => {
            console.log(res)
            setZaal2(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [shownr]);

    // Loads agegroup of show
    useEffect(() => {
        axios.get('https://localhost:7214/api/Leeftijdsgroep/Show/' + shownr)
        .then(res => {
            console.log(res)
            setLeeftijdsgroep2(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [shownr]);

    const handleOnSubmit = async () => {
        const NameChange = document.getElementById("NameChange").value;
        const HallChange = document.getElementById("HallChange").value;
        const AgeChange = document.getElementById("AgeChange").value;
        const GenreChange = document.getElementById("GenreChange").value;
        const ImageChange = document.getElementById("ImageChange").value;

        await fetch('https://localhost:7214/api/Show', {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                "shownr" : shownr,
                "afbeelding" : ImageChange,
                "genre" : GenreChange,
                "naam" : NameChange,
                "leeftijdsgroep" : AgeChange,
                "zaal" : HallChange
            })
        })
        .then(res => res.json())
        .then(data => {
            console.log(data);
        })
        .catch(err => {
            console.log(err);
        })
    }

    return(
        <>
            <Hero2 tekst={titel}/>

            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <p>Naam aanpassen</p>
                    <input type="text" id="NameChange" defaultValue={TitelVoorstelling}/>
                    <br/>

                    <p>Zaal aanpassen</p>
                    <input type="text" id="HallChange" defaultValue={zaal2.naam}/>
                    <br/>

                    <p>Leeftijdsgroep aanpassen</p>
                    <input type="text" id="AgeChange" defaultValue={leeftijdsgroep2.naam}/>
                    <br/>

                    <p>Genre aanpassen</p>
                    <input type="text" id="GenreChange" defaultValue={genre2.naam} />
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