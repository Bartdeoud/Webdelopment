import React from "react";
import { useNavigate, useLocation } from 'react-router-dom';
import Hero2 from "../../Shared/Hero2.js";

const ShowChanger = () => {
    const {state} = useLocation();
    const {
        shownr,
        TitelVoorstelling,
        zaal,
        LinkToImg,
        genre,
        leeftijdsgroep
    } = state;

    const navigate = useNavigate();
    const titel = TitelVoorstelling + " aanpassen";

    const handleSubmit = async (e) => {
        handleOnSubmit();
        navigate('/ShowAanpassen');
    }

    const handleOnSubmit = async (e) => {
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
                    <input type="text" id="HallChange" defaultValue={zaal}/>
                    <br/>

                    <p>Leeftijdsgroep aanpassen</p>
                    <input type="text" id="AgeChange" defaultValue={leeftijdsgroep}/>
                    <br/>

                    <p>Genre aanpassen</p>
                    <input type="text" id="GenreChange" defaultValue={genre} />
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