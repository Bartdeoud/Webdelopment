import React, { useState } from "react";
import Hero2 from "../Shared/Hero2";

const Login = () => {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
        alert(email + password);
    }

    return(
        <>
            <Hero2 tekst = "Inloggen"/>
            <section className="section">
                <form onSubmit={handleSubmit}>
                    <label>
                        Email:
                        <input type="text" id="Email" onChange={(e) => setEmail(e.target.value)}/>
                    </label>
                    <br/><br/>
                    <label>
                        Wachtwoord:
                        <input type="text" id="Wachtwoord" onChange={(e) => setPassword(e.target.value)}/>
                    </label>
                    <br/><br/>
                    <button className="btn" type="submit">Login</button>
                    <br/><br/>
                </form>
            </section>
        </>
    );
}

export default Login;