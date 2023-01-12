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
                <p>Gebruikersnaam</p>
                <input type="text" placeholder={props.tekst} onChange={handleChange}/>
                <p>Wachtwoord</p>
                <input type="password" placeholder={props.tekst} onChange={handleChange}/>
                <button className="btn" onClick={handleSubmit}> Submit </button>
            </form>
            </section>   
        </>
    );
}

export default Login;