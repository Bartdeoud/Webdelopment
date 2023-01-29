import React from 'react';
import Hero2 from '../Shared/Hero2';
import Alinea from '../Shared/Alinea';
import { useState} from "react";
import axios from "../../api/axios";
import Cookies from 'universal-cookie';

const Login = () => {
    const [gebruikersnaam, setGebruikersnaam] = useState("");
    const [wachtwoord, setWachtwoord]=useState("");
    const [success, setSuccess] = useState(false);
    const [errMsg, setErrMsg] = useState("");

    const handleSubmit = async (e) => {
        e.preventDefault();

        try{
            const response = await axios.post("https://localhost:7214/api/Account/login",
                JSON.stringify({UserName: gebruikersnaam,Password: wachtwoord}),
                {
                    headers: {'Content-Type': 'application/json'},
                }
            );
            console.log(response.data)
            const cookies = new Cookies(document.cookies);
            cookies.set("Authorization", "Authorization: Bearer " +  response?.data?.token)
            cookies.set("roles",response?.data?.roles)
            setSuccess(true);
        }catch(err){
            if(!err?.response){
                setErrMsg('No Server Response')
            }else{
                if(err.response?.status === 400){
                    setErrMsg('Gebruikersnaam of wachtwoord ontbreekt');
                }else{
                    setErrMsg('Login lukte niet');
                }
            }
        }
    }

    return (
        <>
            {success ? (
                <>
                    <Hero2 tekst = "Inloggen"/>
                    <Alinea titel="U bent ingelogd" tekst="U bent nu succesvol ingelogd"/>
                </>
            ):(
                <>
                    <Hero2 tekst="Inloggen" />

                    <section className="contact">
                    <p className={errMsg?"errmsg":"offscreen"} aria-live="assertive">{errMsg}</p>
                        <form onSubmit={handleSubmit}>
                            <p>Gebruikersnaam:</p>
                            <input id="username" name='userName' placeholder='Vul hier uw naam in' type="text" onChange={(e)=> setGebruikersnaam(e.target.value)}/>
                            <br/>
                            <p>Wachtwoord:</p>
                            <input id="password" name='password' placeholder='Vul hier uw wachtwoord in' type="password" onChange={(e)=>setWachtwoord(e.target.value)}/>
                            <br/>
                            <button className="btn" type="submit">Log in</button>
                        </form>
                        <br/><br/>
                        <hr/>
                    </section>
                </>
            )} 
        </>
    );
}


export default Login;