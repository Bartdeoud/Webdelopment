import React from 'react';
import Hero2 from '../Shared/Hero2';
import { useState } from "react";

const Login = (props) => {
    const [formData, setFormData] = useState();

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
            <Hero2 tekst="Inloggen" />
                
            <section className="contact">
             <form>
                <label for="gebruikersnaam">Gebruikersnaam</label>
                <input type="text" placeholder={props.tekst} onChange={handleChange} id="gebruikersnaam" name="gebruikersnaam"/>
                <label for="wachtwoord">Wachtwoord</label>
                <input type="password" placeholder={props.tekst} onChange={handleChange} id="wachtwoord" name="wachtwoord"/>
                <button className="btn" onClick={handleSubmit}> Log in </button>
            </form>
            </section>   
        </>
    );
}

export default Login;