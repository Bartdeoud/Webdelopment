import React from 'react';
import Hero2 from '../Shared/Hero2';
import { useRef, useState, useEffect } from "react";
import {faCheck, faTimes, faInfoCircle} from "@fortawesome/free-solid-svg-icons";
import {FontAwesomeIcon} from "@fortawesome/react-fontawesome";
//import PasswordChecklist from "react-password-checklist";

const User_regex = /^[a-zA-Z][a-zA-Z0-9-_]{8,}$/;
const Wachtwoord_regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%]).{8,}$/
const Email_regex = /^[a-zA-Z0-9.!#$%&*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

const Aanmaken = () => {
    const userRef = useRef();
    const errRef = useRef();

    const [user, setUser] = useState("");
    const [naam, setNaam] = useState(false);
    const [validName, setValidName] = useState(false);
    const [userFocus, setUserFocus] = useState(false);

    const [password, setPassword] = useState("");
    const [validPwd, setValidPwd] = useState(false);
    const [pwdFocus, setPwdFocus] = useState(false);

    const [confirmPassword, setConfirmPassword] = useState("");
    const [validMatch, setValidMatch] = useState(false);
    const [matchFocus, setMatchFocus] = useState(false);

    const [email, setEmail] = useState("");
    const [validEmail, setValidEmail]=useState(false);
    const [emailFocus, setEmailFocus]=useState(false);

    
    const [errMsg, setErrMsg] = useState("");
    const [success, setSuccess] = useState(false);


    const handleSubmit = async (e) => {
        e.preventDefault();
        const v1 = User_regex.test(user);
        const v2 = Wachtwoord_regex.test(password);
        const v3 = Email_regex.test(email);
        if(!v1||!v2||!v3){
            setErrMsg("Een of meerdere ingevoerde gegevens zijn incorrect.")
            return;
        }
        alert(naam + email);
    }

    useEffect(()=>{ //user
        const result = User_regex.test(user);

        setValidName(result);
    },[user])

    useEffect(()=>{ //password
        const result = Wachtwoord_regex.test(password);

        setValidPwd(result);
        const match = password === confirmPassword;
        setValidMatch(match);
    },[password, confirmPassword])

    useEffect(()=>{//emailadres
        const result = Email_regex.test(email);

        setValidEmail(result);
    },[email])

    useEffect(()=>{
        setErrMsg("");
    },[user, password, confirmPassword,email])

    return(
        <>
            <Hero2 tekst="Account aanmaken" />
            {success ? (
                <section>
                    <h1>Account aanmaken is gelukt!</h1>
                </section>
                )
                : 
                (
                    <section className="contact">
                        <p ref={errRef} className={errMsg ? "errmsg" : "offscreen"} aria-live="assertive">{errMsg}</p>
                        <form onSubmit={handleSubmit}>
                            <label htmlFor="username">
                                Gebruikersnaam:
                                <span className={validName ? "valid" : "hide"}>
                                    <FontAwesomeIcon icon={faCheck}/>
                                </span>
                                <span className={validName || !user ? "hide" : "invalid"}>
                                    <FontAwesomeIcon icon={faTimes}/>
                                </span>
                            </label><br/>
                            <input 
                                type="text" 
                                id="username" 
                                ref={userRef} 
                                autoComplete="off" 
                                onChange={(e)=>setUser(e.target.value)} 
                                required
                                aria-invalid={validName ? "false" :  "true"}
                                aria-describedby="uidnote"
                                onFocus={()=>setUserFocus(true)}
                                onBlur={()=>setUserFocus(false)}
                            />
                            <p id="uidnote" className={userFocus && user && !validName ? "instructions" : "offscreen"}>
                                <FontAwesomeIcon icon={faInfoCircle}/>
                                Minimaal 8 karakters
                                Begint met een letter
                                Letters, nummers, underscore, streepjes toegestaan.
                            </p>

                            <label htmlFor="emailadres">
                                E-mail adres:
                                <span className={validEmail ? "valid" : "hide"}>
                                    <FontAwesomeIcon icon={faCheck}/>
                                </span>
                                <span className={validName || !user ? "hide" : "invalid"}>
                                    <FontAwesomeIcon icon={faTimes}/>
                                </span>
                            </label><br/>
                            <input 
                                type="email" 
                                id="emailadres" 
                                ref={userRef} 
                                autoComplete="off" 
                                onChange={(e)=>setEmail(e.target.value)} 
                                required
                                aria-invalid={validName ? "false" :  "true"}
                                aroa-describedby="emailnote"
                                onFocus={()=>setEmailFocus(true)}
                                onBlur={()=>setEmailFocus(false)}
                            />
                            <br/>

                            <label htmlFor="password">
                                Wachtwoord:
                                <span className={validPwd ? "valid": "hide"}>
                                    <FontAwesomeIcon icon={faCheck}/>
                                </span>
                                <span className={validPwd || !password ? "hide" : "invalid"}>
                                    <FontAwesomeIcon icon={faTimes}/>
                                </span>
                            </label><br/>
                            <input
                                type="password"
                                id="password" 
                                onChange={(e)=>setPwdFocus(e.target.value)} 
                                required 
                                aria-invalid={validPwd ? "false" : "true"}
                                aria-describedby="pwdnote"
                                onFocus={()=>setPwdFocus(true)}
                                onBlur={()=>setPwdFocus(false)}
                            />
                            <p id="pwdnote" className={pwdFocus && !validPwd ? "instructions" : "offscreen"}>
                                <FontAwesomeIcon icon={faInfoCircle}/>
                                Minimaal 7 karakters. <br/>
                                Bevat minimaal 1 kleine letter, 1 hoofdletter, 1 cijfer en 1 speciaal teken.<br/>
                                Toegestane speciale tekens: <span aria-label="uitroepteken">!</span> <span aria-label="apenstaartje">@</span> <span aria-label="hekje">#</span> <span aria-label="dollar teken">$</span> <span aria-label="procennt">%</span>
                            </p>
                                
                            <label htmlFor="confirm_pwd">
                                Bevestig wachtwoord:
                                <span className={validMatch && confirmPassword ? "valid": "hide"}>
                                    <FontAwesomeIcon icon={faCheck}/>
                                </span>
                                <span className={validMatch || !confirmPassword ? "hide" : "invalid"}>
                                    <FontAwesomeIcon icon={faTimes}/>
                                </span>
                            </label><br/>
                            <input 
                                type="password"
                                id="confirm_pwd"
                                onChange={(e)=>setConfirmPassword(e.target.value)}
                                required
                                aria-invalid={validMatch ? "false" : "true"}
                                aria-describedby="contirmnote"
                                onFocus={()=>setMatchFocus(true)}
                                onBlur={()=>setMatchFocus(false)}
                            />

                            <button disabled={!validName || !validEmail  || !validPwd || !validMatch ? true : false}>
                                    Registreer
                            </button>
                        </form>
                    </section>
                )
            }
        </>
    )
}

export default Aanmaken;