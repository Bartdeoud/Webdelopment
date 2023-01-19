import React from 'react';
import Hero2 from '../Shared/Hero2';
import { useState } from "react";

const Login = (props) => {
    const [gebruikersnaam, setGebruikersnaam] = useState("");
    const [wachtwoord, setWachtwoord]=useState("");

    //e staat voor event
    const handleChange = (e) => {
        //setFormData(e.target.value);
    }

    const handleSubmit = (e) => {
        e.preventDefault();
        //alert(formData);
    }

    return (
        <>
            <Hero2 tekst="Inloggen" />
                
            <section className="contact">
             <form onSubmit={handleSubmit}>
                <label htmlFor="gebruikersnaam">Gebruikersnaam</label>
                <input value={gebruikersnaam} type="text" placeholder={props.tekst} onChange={handleChange} id="gebruikersnaam" name="gebruikersnaam"/>
                <br/>
                <label htmlFor="wachtwoord">Wachtwoord</label>
                <input value={wachtwoord} type="password" placeholder={props.tekst} onChange={handleChange} id="wachtwoord" name="wachtwoord"/>
                <button className="btn" onClick={handleSubmit} type="submit"> Log in </button>
            </form>
            </section>   
        </>
    );
}

export default Login;