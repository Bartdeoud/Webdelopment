import React, { useState }  from 'react';
import Hero2 from '../Shared/Hero2';

const EvenementToevoegen = () => {
    const [shownaam, setNaam] = useState();
    const [showzaal, setZaal] = useState();
    const [leeftijd, setLeeftijd] = useState();
    const [showgenre, setGenre] = useState();

    const handleSubmit = async () => {
        try {
          let res = await fetch("https://localhost:7214/api/Show", {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
            },
            body: JSON.stringify({
              shownr: 0,
              afbeelding: "string",
              genre: showgenre,
              naam: shownaam,
              leeftijdsgroep: leeftijd,
              zaal: showzaal,
              beginTijd: "2023-01-22T22:09:07.168Z",
              eindTijd: "2023-01-22T22:09:07.168Z"
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
                    <button className="btn" onClick={handleSubmit}> Submit </button>
                </form>
            </section>   
        </>
    );
}

export default EvenementToevoegen;