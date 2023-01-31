import React, { useState } from "react";
import Hero2 from "../Shared/Hero2";
import axios from 'axios';

const Doneren = () => {
    const [bedrag,setbedrag] = useState()
    const [email,setemail] = useState()

    function Donate(){
        axios.post("https://localhost:7214/api/Doneren/getSession?Email=" + email + "&bedrag=" + bedrag)
        .then(res => {
            window.location.href = "https://ikdoneer.azurewebsites.net/Toegang?url=https://localhost:7214/api/Doneren?session=" + res.data
        })
        .catch(err =>{
            console.log(err)
        })
    }

    return (
        <>
            <Hero2 tekst="Doneren"/>
            <section className="contact">
            <form id="FormDoneer" method="post">
                <p>Bedrag:</p>
                <input id="bedrag" required placeholder='Vul hier uw bedrag in' type="number" min={1} max={1000} onChange={(e)=>setbedrag(e.target.value)}/>
                <br/>
                <p>Email:</p>
                <input id="emailneefjeweettochikbenkaulorijkwantikdoneeraaneenpaupertheater" type="email" required placeholder="Voer hier uw email in" onChange={e => setemail(e.target.value)}></input>
            </form>
            <button className="btn" type="onClick" onClick={Donate}>Doneren</button>
            </section>
        </>
    )
}

export default Doneren;