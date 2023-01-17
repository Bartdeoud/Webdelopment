import React from "react";
import Hero2 from "../Shared/Hero2";
// import { useState } from "react";
import FakePay from "./FakePay";

const Winkelmand = () => {
    // const [totaal, setTotaal] = useState("");

    // const handleSubmit = () =>{
    //     const data = fetch('https://fakepay.azurewebsites.net/', {
    //         method: 'POST',
    //         headers:{
    //           'Content-Type': 'application/x-www-form-urlencoded'
    //         },    
    //         body: new URLSearchParams({
    //             'amount': '234',
    //             'reference': 'Betaal',
    //             'url': 'https://www.google.com/'
    //         })
    //     });
    //     console.log(data);
    // }

    return(
        <>
            <Hero2 tekst="Winkelmand"/>
        </>
    );
}

export default Winkelmand;