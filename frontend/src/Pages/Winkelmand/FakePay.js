import React, { useState } from 'react';
import { Form, Button } from 'react-bootstrap';

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

    const handleSubmit = async () => {
        console.log ("handleOnSubmit");
        await fetch('https://fakepay.azurewebsites.net/', {
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
    }

    if (html === undefined || html === ""){
        return (
            <section className='contact'>
                <Form onSubmit={handleSubmit}>
                    <Form.Group controlId="name">

                    <Form.Label> &nbsp; Totaal aantal kaarten:</Form.Label>
                    <p>{props.totaal}</p>

                    <br/>

                    <Form.Label> &nbsp; Te betalen bedrag:</Form.Label>
                    <p>€ {props.bedrag},00</p>
                        
                    </Form.Group>
                    <br/>
                    <Button className='btn' type="submit"> Submit </Button>
                </Form>
                <br/>
                <hr/>
            </section>
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