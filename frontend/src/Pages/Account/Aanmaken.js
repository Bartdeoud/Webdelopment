import React from 'react';
import Hero2 from '../Shared/Hero2';
import { useState } from "react";
import PasswordChecklist from "react-password-checklist"


const Aanmaken = (props) => {
    const [formData, setFormData] = useState();
    const [password, setPassword] = useState("");
    const [password2, setPassword2] = useState("");

    //e staat voor event
    const handleChange = (e) => {
        setFormData(e.target.value);
    }

    const handleSubmit = (e) => {
        e.preventDefault();
        alert(formData);
    }

    return (
        <>
            <Hero2 tekst="Account aanmaken" />
                
            <section className="contact">
             <form>
                <p>Gebruikersnaam</p>
                <input type="text" onChange={handleChange}/>
                
                <p>Wachtwoord</p>
                <input type="password" onChange={e => setPassword(e.target.value)}/>
                <p>Wachtwoord herhalen</p>
                <input type="password" onChange={e => setPassword2(e.target.value)}/>

                <PasswordChecklist
				rules={["minLength","specialChar","number","capital","match"]}
				minLength={5}
				value={password}
				valueAgain={password2}
                messages={{
                    minLength: "Minimaal 5 karakters",
                    specialChar: "Minimaal 1 speciaal karakter",
                    number: "Minimaal 1 getal",
                    capital: "Minimaal 1 hoofdletter",
                    match: "Wachtwoorden moeten overeen komen",
                }}
				onChange={(isValid) => {}}
			    />
                <br></br>

                <p>Email</p>
                <input type="email" placeholder={props.tekst} onChange={handleChange}/>

                <p>Geboortedatum</p>
                <input type="date" placeholder={props.date} onChange={handleChange}/>

                <button className="btn" onClick={handleSubmit}> Submit </button>
            </form>
            </section>   
        </>
    );
}

export default Aanmaken;