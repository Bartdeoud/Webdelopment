import React, { useState } from "react";
import Hero2 from "../Shared/Hero2";

const ZaalToevoegen = () => {
    const [naamX, setNaamX] = useState("");
    const [rang1X, setRang1X] = useState(0);
    const [rang2X, setRang2X] = useState(0);
    const [rang3X, setRang3X] = useState(0);
    const [rang4X, setRang4X] = useState(0);
    const [invalideplaatsenX, setInvalideplaatsenX] = useState();

    const handleSubmit = async () => {
        if (check()){
            await handleOnSubmit()
            alert("Zaal is toegevoegd")
        }else{
            alert("Vul alle velden correct in")
        }
    }
    
    const check = () => {
        if (naamX === "" || naamX === undefined || rang1X === 0 || rang1X === undefined){
            return false
        }else{
            return true
        }
    }

    const handleOnSubmit = async () => {
        try {
            let res = await fetch("https://localhost:7214/api/Zaal", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({
                    zaalnr: 0,
                    naam: naamX,
                    rang1: rang1X,
                    rang2: rang2X,
                    rang3: rang3X,
                    rang4: rang4X,
                    invalideplaatsen: invalideplaatsenX,
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
            <Hero2 tekst="Zaal toevoegen"/>
            <section className="contact">
                <form onSubmit={handleSubmit}>
                    <p>Naam zaal</p>
                    <input type="text" name="naam" placeholder="Naam zaal" onChange={e => setNaamX(e.target.value)}/>
                    <p>Rang 1</p>
                    <input type="number" name="rang1" placeholder="Rang 1" onChange={e => setRang1X(e.target.value)}/>
                    <p>Rang 2</p>
                    <input type="number" name="rang2" placeholder="Rang 2" onChange={e => setRang2X(e.target.value)}/>
                    <p>Rang 3</p>
                    <input type="number" name="rang3" placeholder="Rang 3" onChange={e => setRang3X(e.target.value)}/>
                    <p>Rang 4</p>
                    <input type="number" name="rang4" placeholder="Rang 4" onChange={e => setRang4X(e.target.value)}/>
                    <p>Invalideplaatsen</p>
                    <input type="number" name="invalideplaatsen" placeholder="Invalideplaatsen" onChange={e => setInvalideplaatsenX(e.target.value)}/>
                    <br/>
                    <hr/>
                    <button className="btn" type="submit">Toevoegen</button>
                </form>
            </section>
        </>
    );
}

export default ZaalToevoegen;