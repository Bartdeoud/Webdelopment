import React, { useState }  from 'react';
import Hero2 from '../Shared/Hero2';
// import { DayPicker } from "react-day-picker";
import 'react-day-picker/dist/style.css';
import Alinea from "../Shared/Alinea";

const Huren = () => {
    // const [day, setDay] = useState();
    const [hurenNaam, setNaam] = useState();
    //const [userID, getID] = useState();
    const [hurenZaal, setZaal] = useState();
    const [hurenRuimte, setRuimte] = useState();

    const handleSubmit = (e) => {
        handleOnSubmit();
      }
  
      const handleOnSubmit = async () => {
          try {
            let res = await fetch("https://localhost:7214/api/Huren", {
              method: "POST",
              headers: {
                "Content-Type": "application/json",
              },
              body: JSON.stringify({
                id: 0,
                naam: hurenNaam,
                datum:  "2023-01-22T22:09:07.168Z",
                verhuurdeId: 0,
                zaalnr: hurenZaal,
                ruimteNr: hurenRuimte,
              }),
            });
            if (res.status === 200) {
              console.log("succes");
            }
          } catch (err) {
            console.log(err);
          }
        }
  
    try{
        //cookies users
        return (
            <>
                <Hero2 tekst= "Huren" />
                <section className="contact">
                    <form>
                        <p>Naam evenement</p>
                        <input type="text" placeholder="Voer hier de naam van uw reservering in" onChange={(e)=>setNaam(e.target.value)}/>
    
                        <p>Zaal</p>
                        <select required="required"  onChange={(e)=>setZaal(e.target.value)}>
                            <option value="" disabled selected>Selecteer een zaal</option>
                            <option value="null">geen</option>
                            <option value="zaal1">Zaal 1</option>
                            <option value="zaal2">Zaal 2</option>
                            <option value="zaal3">Zaal 3</option>
                            <option value="zaal4">Zaal 4</option>
                        </select>
    
                        <p>Ruimte</p>
                        <select required="required"  onChange={(e)=>setRuimte(e.target.value)}>
                            <option value="null" disabled selected>Selecteer een ruimte</option>3
                            <option value="geen">Geen</option>
                            <option value="ruimte1">Ruimte 1</option>
                            <option value="ruimte2">Ruimte 2</option>
                            <option value="ruimte3">Ruimte 3</option>
                            <option value="ruimte4">Ruimte 4</option>
                            <option value="ruimte5">Ruimte 5</option>
                            <option value="ruimte6">Ruimte 6</option>
                            <option value="ruimte7">Ruimte 7</option>
                            <option value="ruimte8">Ruimte 8</option>
                            <option value="ruimte9">Ruimte 9</option>
                            <option value="ruimte10">Ruimte 10</option>
    
                        </select>
    
                        <br/>
    
                        {/* <p>Dagen</p>
                        <DayPicker
                            mode="single"
                            selected={day}
                            onSelect={setDay}
                        /> */}
    
                        <button className="btn" onClick={handleSubmit}> Submit </button>
                    </form>
                </section>   
            </>
        );

    }catch{
        return(
            <>
                <Hero2 tekst="Huren"/>
                <Alinea titel="Uw moet eerst inloggen om een zaal te huren." link="/Account" linknaam="Log in om te kunnen huren."/>
            </>
        );
    }

    
}

export default Huren;