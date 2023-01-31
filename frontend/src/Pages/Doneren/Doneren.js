import React, { useState } from "react";
import Hero2 from "../Shared/Hero2";
import axios from 'axios';

const Doneren = () => {
    const [bedrag,setbedrag] = useState()
    const [email,setemail] = useState()

    function hasToken(){
        return new URLSearchParams(window.location.search).get("token") != null;
    }

    function Donate(){
        axios.post("https://localhost:7214/api/Doneren/getSession?Email=" + email + "&bedrag=" + bedrag)
        .then(res => {
            window.location.href = "https://ikdoneer.azurewebsites.net/Toegang?url=https://localhost:7214/api/Doneren?session=" + res.data
        })
        .catch(err =>{
            console.log(err)
        })
    }


    if(!hasToken())
    return (
        <>
            <Hero2 tekst="Doneren"/>
            <form id="FormDoneer" method="post">
                <input id="bedrag" required placeholder='Vul hier uw bedrag in' type="text" onChange={(e)=>setbedrag(e.target.value)}/>
                <br/>
                <input type="email" required placeholder="Voer hier uw email in" onChange={e => setemail(e.target.value)}></input>
                <br/>
            </form>
            <button className="btn" type="onClick" onClick={Donate}>Doneren</button>
        </>
    )
    return(
        <>
            <Hero2 tekst="Doneren"/>
        </>
    )
}

export default Doneren;