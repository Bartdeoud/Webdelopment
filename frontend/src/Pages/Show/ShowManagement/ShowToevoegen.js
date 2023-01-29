import axios from 'axios';
import React, { useEffect, useState }  from 'react';
import Hero2 from '../../Shared/Hero2';

const ShowToevoegen = () => {
    const [naamX, setNaam] = useState("");
    const [image, setImage] = useState("");

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

    const handleSubmit = async (e) => {
        try {
            let res = await fetch("https://localhost:7214/api/Show", {
                method: "POST",
                headers: {
                "Content-Type": "application/json",
                },
                body: JSON.stringify({
                shownr: 0,
                afbeelding: image,
                genre: genreApi,
                naam: naamX,
                beginTijd: "2023-01-27T10:41:32.651Z",
                eindTijd: "2023-01-27T10:41:32.651Z",
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
    };

    return (
        <>
            <Hero2 tekst="Show Toevoegen" />
            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <p>Naam evenement</p>
                    <input type="text" id="Name" required placeholder="Voer hier de naam van de show in" onChange={(e) => setNaam(e.target.value)}/>

                    <p>Afbeelding</p>
                    <input type="text" id="Image" defaultValue="" placeholder="Voer hier de afbeelding van de show in" onChange={(e) => setImage(e.target.value)}/>

                    <p>Genre</p>
                    <select id="genre" required onChange={(e) => setGenreApi(e.target.value)}>
                        <option value="" disabled selected>Selecteer een genre</option>
                        {genre.map(genre => (
                            <option key={genre.genreID} value={genre.genreID}>{genre.naam}</option>
                        ))}
                    </select>

                    <p>Leeftijdsgroep</p>
                    <select id="leeftijd" required onChange={(e) => setLeeftijdsgroepApi(e.target.value)}>
                        <option value="" disabled selected>Selecteer een leeftijdsgroep</option>
                        {leeftijdsgroep.map(leeftijds => (
                            <option key={leeftijds.leeftijdsgroepID} value={leeftijds.leeftijdsgroepID}>{leeftijds.naam}</option>
                        ))}
                    </select>

                    <p>Zaal</p>
                    <select id="zaal" required onChange={(e) => setZaalApi(e.target.value)}>
                        <option value="" disabled selected>Selecteer een zaal</option>
                        {zaal.map(zaal => (
                            <option key={zaal.zaalnr} value={zaal.zaalnr}>{zaal.naam}</option>
                            ))}
                    </select>
                    
                    <button className="btn" type="submit"> Toevoegen </button>
                </form>
            </section>   
        </>
    );
}

export default ShowToevoegen;