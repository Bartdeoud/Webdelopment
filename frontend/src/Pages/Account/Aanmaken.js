import React from 'react';
import Hero2 from '../Shared/Hero2';
import { useState } from "react";

const Aanmaken = () => {
    const [naam, setNaam] = useState();
    const [password, setPassword] = useState("");
    const [password2, setPassword2] = useState("");
    const [email, setEmail] = useState();
    const [date, setDate] = useState();

    const handleSubmit = (e) => {
        e.preventDefault();
        alert(naam + email + date);
    }

    return (
        <>
            <Hero2 tekst="Account aanmaken" />
                
            <section className="contact">
             <form>
                <p>Gebruikersnaam</p>
                <input type="text" onChange={e => setNaam(e.target.value)}/>
                
                <p>Wachtwoord</p>
                <input type="password" onChange={e => setPassword(e.target.value)}/>
                <p>Wachtwoord herhalen</p>
                <input type="password" onChange={e => setPassword2(e.target.value)}/>

                <PasswordChecklist
                //these are the default rules
				rules={["minLength","specialChar","number","capital","match"]}
				minLength={5}
				value={password}
				valueAgain={password2}
                messages={{
                    // this changes the default messages
                    minLength: "Minimaal 5 karakters",
                    specialChar: "Minimaal 1 speciaal karakter",
                    number: "Minimaal 1 getal",
                    capital: "Minimaal 1 hoofdletter",
                    match: "Wachtwoorden moeten overeen komen",
                }}
				onChange={() => {}}
			    />
                <br></br>

                <p>Email</p>
                <input type="email" onChange={e => setEmail(e.target.value)}/>

                <p>Geboortedatum</p>
                <input type="date" onChange={e => setDate(e.target.value)} />

                <button className="btn" onClick={handleSubmit}> Submit </button>
            </form>
            </section>   
        </>
    );
}

export default Aanmaken;