import React, { useEffect, useState } from 'react';
import Alinea from '../Shared/Alinea';

const FakePay = (props) => {

    var details = {
        "amount": props.bedrag,
        'reference': '123456789', 
        'url': '',
    };

    var formBody = [];
    for (var property in details) {
        var encodedKey = encodeURIComponent(property);
        var encodedValue = encodeURIComponent(details[property]);
        formBody.push(encodedKey + "=" + encodedValue);
    }
    formBody = formBody.join("&");

    const [html, setHTML] = useState("");
    let code = `${html}`;

    useEffect(() => {
        fetch('https://fakepay.azurewebsites.net/', {
            method: 'POST',
            headers:{
            'Accept': 'application/x-www-form-urlencoded;charset=UTF-8',
            'Content-Type': 'application/x-www-form-urlencoded;charset=UTF-8',
            'Access-Control-Allow-Origin': '*'},    
            body: formBody
        })
            .then(response => {
            return response.text();
        })
            .then(response => {
            return setHTML(response);
        })
    });

    if (html === undefined || html === ""){
        return (
            <Alinea titel="Oeps er is iets mis gegaan" 
            tekst="Probeer het later nog eens"
            link="/"
            linknaam="Ga terug naar de homepagina"/>
        )
    }else{
        return (
            <section className='contact'>
                <div dangerouslySetInnerHTML={{ __html: code}}/>
            </section>
        );
    }
}

export default FakePay;