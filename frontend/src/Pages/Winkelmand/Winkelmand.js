import React from "react";
import Hero2 from "../Shared/Hero2";
// import { useState } from "react";

const Winkelmand = () => {
    // const [totaal, setTotaal] = useState("");

    let handleSubmit = () =>{
        const data = fetch('https://fakepay.azurewebsites.net/', {
            method: 'POST',
            headers:{
              'Content-Type': 'application/x-www-form-urlencoded'
            },    
            body: new URLSearchParams({
                'amount': '234',
                'reference': 'Betaal',
                'url': 'https://www.google.com/'
            })
        });
        console.log(data);
        // return {data}
    }

    return(
        <>
            <Hero2 tekst="Winkelmand"/>

            <iframe src="" width="90%" height="400px" title="Betaalscherm" />

            <form onSubmit={handleSubmit}>
                {/* <input type="number" placeholder="Totaal" onChange={(e) => setTotaal(e.target.value)} /> */}
                <input type="submit" value="Submit" />
            </form>
        </>
    );
}

export default Winkelmand;