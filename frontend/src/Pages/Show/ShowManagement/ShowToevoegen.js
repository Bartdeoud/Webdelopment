import axios from 'axios';
import React, { useEffect, useState }  from 'react';
import Hero2 from '../../Shared/Hero2';

const ShowToevoegen = () => {
    const [genre, setGenre] = useState([]);
    const [zaal, setZaal] = useState([]);
    const [leeftijdsgroep, setLeeftijdsgroep] = useState([]);

    const [genreApi, setGenreApi] = useState();
    const [zaalApi, setZaalApi] = useState();
    const [leeftijdsgroepApi, setLeeftijdsgroepApi] = useState([]);

    useEffect(() => {
        axios.get('https://localhost:7214/api/Zaal')
        .then(res => {
            setZaal(res.data)
        })
        .catch(err =>{
            console.log(err)
        })

        axios.get('https://localhost:7214/api/Genre')
        .then(res => {
            setGenre(res.data)
        })
        .catch(err =>{
            console.log(err)
        })

        axios.get('https://localhost:7214/api/Leeftijdsgroep')
        .then(res => {
            setLeeftijdsgroep(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);

    const handleSubmit = async () => {
        const Name = document.getElementById("Name").value;
        const Image = document.getElementById("Image").value;   
        try {
            let res = await fetch("https://localhost:7214/api/Show", {
                method: "POST",
                headers: {
                "Content-Type": "application/json",
                },
                body: JSON.stringify({
                shownr: 0,
                afbeelding: Image,
                genre: genreApi,
                naam: Name,
                leeftijdsgroep: leeftijdsgroepApi,
                zaal: zaalApi
                }),
            });
          if (res.status === 200) {
            console.log("succes");
        }
        } catch (err) {
            console.log(err);
        }
    }

    return (
        <>
            <Hero2 tekst="Show Toevoegen" />
            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <p>Naam evenement</p>
                    <input type="text" id="Name" placeholder="Voer hier de naam van de show in"/>

                    <p>Afbeelding</p>
                    <input type="text" id="Image" defaultValue="" placeholder="Voer hier de afbeelding van de show in"/>

                    <p>Genre</p>
                    <select onChange={(e) => setGenreApi(e.target.value)}>
                        <option value="" disabled selected>Selecteer een genre</option>
                        {genre.map(genre => (
                            <option key={genre.genreID} value={genre.genreID}>{genre.naam}</option>
                        ))}
                    </select>

                    <p>Leeftijdsgroep</p>
                    <select onChange={(e) => setLeeftijdsgroepApi(e.target.value)}>
                        <option value="" disabled selected>Selecteer een leeftijdsgroep</option>
                        {leeftijdsgroep.map(leeftijds => (
                            <option key={leeftijds.leeftijdsgroepID} value={leeftijds.leeftijdsgroepID}>{leeftijds.naam}</option>
                        ))}
                    </select>

                    <p>Zaal</p>
                    <select onChange={(e) => setZaalApi(e.target.value)}>
                        <option value="" disabled selected>Selecteer een zaal</option>
                        {zaal.map(zaal => (
                            <option key={zaal.zaalnr} value={zaal.zaalnr}>{zaal.naam}</option>
                            ))}
                    </select>
                    
                    <button className="btn" type="submit"> submit </button>
                </form>
            </section>   
        </>
    );
}

export default ShowToevoegen;