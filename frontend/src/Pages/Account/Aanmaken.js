import React from 'react';
import Hero2 from '../Shared/Hero2';
import { useRef, useState, useEffect } from "react";
import {faCheck, faTimes, faInfoCircle} from "@fortawesome/free-solid-svg-icons";
import {FontAwesomeicon} from "@fortawesome/react-fontawesome";
//import PasswordChecklist from "react-password-checklist";

/*https://www.npmjs.com/package/react-password-checklist*/
/*https://www.youtube.com/watch?v=brcHK3P6ChQ&list=PL0Zuz27SZ-6PRCpm9clX0WiBEMB70FWwd&ab_channel=DaveGray form validation EN ACCESSIBILIITY VOOR SCREENREADER*/

const User_regex = /^[a-zA-Z][a-zA-Z0-9-_]{8,}$/;
const Wachtwoord_regex = /^(?=.*[a-z])(?.*[A-Z])(?=.*[0-9])(?+.*[!@#$%]){7,}$/;
const Email_regex = /^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

const Aanmaken = () => {
    const [user, setUser] = useState("");
    const [naam, setNaam] = useState(false);
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
        alert(naam + email + date);
    }

    useEffect(()=>{
        userRef.current.focus();
    },[])

    useEffect(()=>{ //user
        const result = User_regex.test(user);
        console.log(result);
        console.log(user);
        setValidName(result);
    },[user])

    useEffect(()=>{ //password
        const result = Wachtwoord_regex.test(password);
        console.log(result); //TODO delete this line row when live
        console.log(password); //TODO delete this row when live
        setValidPwd(result);
        const match = pwd === confirmPassword;
        setValidMatch(match);
    },[password, confirmPassword])

    useEffect(()=>{//emailadres
        const result = Email_regex.test(email);
        console.log(result);
        console.log(email);
        setValidEmail(result);
    },[email])

    useEffect(()=>{
        setErrMsg("");
    },[user, password, confirmPassword,email])

    return(
        <>
            <Hero2 tekst="Account aanmaken" />
            <section classname="contact">
                <p ref={errRef} className={errMsg ? "errmsg" : "offscreen"} aria-live="assertive">{errMsg}</p>
                <form onSubmit={handleSubmit}>
                    <label htmlFor="username">
                        Gebruikersnaam:
                        <span className={validName ? "valid" : "hide"}>
                            <FontAwesomeicon icon={faCheck}/>
                        </span>
                        <span className={validName || !user ? "hide" : "invalid"}>
                            <FontAwesomeIcon icon={faTimes}/>
                        </span>
                    </label>
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
                    <p id="uidnote" classname={userFocus && user && !validName ? "instructions" : "offscreen"}>
                        <FontAwesomeicon icon={faInfoCircle}/>
                        Minimaal 8 karakters
                        Begint met een letter
                        Letters, nummers, underscore, streepjes toegestaan.
                    </p>

                    <label htmlFor="emailadres">
                        E-mail adres:
                        <span className={validEmail ? "valid" : "hide"}>
                            <FontAwesomeicon icon={faCheck}/>
                        </span>
                        <span className={validName || !user ? "hide" : "invalid"}>
                            <FontAwesomeIcon icon={faTimes}/>
                        </span>
                    </label>
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
                    <p id="uidnote" classname={userFocus && user && !validName ? "instructions" : "offscreen"}>
                        <FontAwesomeicon icon={faInfoCircle}/>
                        Voer een geldig e-mailadres in.
                    </p>

                    <label htmlFor="password">
                        Wachtwoord:
                        <span className={validPwd ? "valid": "hide"}>
                            <FontAwesomeicon icon={faCheck}/>
                        </span>
                        <span classname={validPwd || !password ? "hide" : "invalid"}>
                            <FontAwesomeicon icon={faTimes}/>
                        </span>
                    </label>
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
                        <FontAwesomeicon icon={faInfoCircle}/>
                        Minimaal 7 karakters. <br/>
                        Bevat minimaal 1 kleine letter, 1 hoofdletter, 1 cijfer en 1 speciaal teken.<br/>
                        Toegestane speciale tekens: <span aria-label="uitroepteken">!</span> <span aria-label="apenstaartje">@</span> <span aria-label="hekje">#</span> <span aria-label="dollar teken">$</span> <span aria-label="procennt">%</span>
                    </p>
                        
                    <label htmlFor="confirm_pwd">
                        Bevestig wachtwoord:
                        <span className={validMatch && confirmPassword ? "valid": "hide"}>
                            <FontAwesomeicon icon={faCheck}/>
                        </span>
                        <span classname={validMatch || !confirmPassword ? "hide" : "invalid"}>
                            <FontAwesomeicon icon={faTimes}/>
                        </span>
                    </label>
                    <input 
                        type="password"
                        id="confirm_pwd"
                        onChange={(e)=>setMatchPwd(e.target.value)}
                        required
                        aria-invalid={validMatch ? "false" : "true"}
                        aria-describedby="contirmnote"
                        onFocus={()=>setMatchFocus(true)}
                        onBlur={()=>setMatchFocus(false)}
                    />

                    <button 
                        disabled={!validName || !validEmail  || !validPwd || !validMatch ? true : false}
                    >
                            Registreer
                    </button>
                </form>
            </section>
        </>
    )
    /*return (
        <>
            <Hero2 tekst="Account aanmaken" />
                
            <section className="contact">
             <form>
                <p>*verplicht</p>
                <label htmlFor="Username">*Gebruikersnaam:</label>
                <input type="text" onChange={e => setNaam(e.target.value)} id="Username" name="Username" required/>
                <br/>
                <label htmlFor="Wachtwoord">*Wachtwoord:</label>
                <input type="password" pattern="(?=.*[a-z])(?=.*[A-Z])(?=.*[$&+,:;=?@#|'<>.^*()%!-]).{7,}" onChange={e => setPassword(e.target.value)} id="Wachtwoord" name="Wachtwoord" required/>
                <br/>
                <label htmlFor="herhaalWachtwoord">*Bevestig wachtwoord:</label>
                <input type="password" onChange={e => setConfirmPassword(e.target.value)} id="herhaalWachtwoord" name="herhaalWachtwoord" required/>

                <PasswordChecklist
                    //these are the default rules
                    rules={["minLength","specialChar","number","capital","lowercase","match"]}
                    minLength={7}
                    capital={1}
                    lowercase={1}
                    specialChar={1}
                    value={password}
                    valueAgain={confirmPassword}
                    messages={{
                        // this changes the default messages
                        minLength: "Minimaal 7 karakters",
                        specialChar: "Minimaal 1 speciaal karakter",
                        number: "Minimaal 1 getal",
                        capital: "Minimaal 1 hoofdletter",
                        lowercase: "Minimaal 1 kleine letter",
                        match: "Wachtwoorden moeten overeen komen",
                    }}
                    onChange={(isValid) => {}}
			    />
                <br></br>

                <p>*Email</p>
                <input type="email" onChange={e => setEmail(e.target.value)} required/>
                
                <p>Geboortedatum</p>
                <input type="date" onChange={e => setDate(e.target.value)} />

                <button className="btn" onClick={handleSubmit}> Submit </button>
            </form>
            </section>   
        </>
    );*/
}

export default Aanmaken;