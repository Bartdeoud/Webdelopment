import React, { useState } from 'react';




const [html, setHTML] = useState("");
const FakePay = async (order) => {
    

    await fetch('https://fakepay.azurewebsites.net/', {
        method: 'POST',
        headers:{
          'Content-Type': 'application/x-www-form-urlencoded',
          'Access-Control-Allow-Origin': '*'
        },    
        body: formBody
    })
    .then(response => {
        return response.text();
    })
    .then(response => {
        return setHTML(response);
    })
}