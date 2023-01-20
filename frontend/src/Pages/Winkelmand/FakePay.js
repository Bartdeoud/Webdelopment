import React, { useState } from 'react';
import { Form, Button } from 'react-bootstrap';

const FakePay = () => {
    var [amount , setAmount] = useState('');

    const handleChange = (e) => {
        if (e.target.value < 0 || e.target.value === ""){
            setAmount(10);
        }else{
            setAmount(e.target.value);
        }
    };
    
    const handleSubmit = (e) => {
        e.preventDefault();
        const Order = {
            amount
        };
        handleOnSubmit(Order);
    };

    var details = {
        "amount": amount,
        'reference': '123456789', 
        'url': 'https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/winkelmand',
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

    const handleOnSubmit = async (order) => {
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
                        <Form.Label> &nbsp; Te betalen bedrag:</Form.Label>
                        <br/>
                        <br/>
                        <Form.Control
                            type="number"
                            placeholder="Amount"
                            required min="1"
                            value={amount}
                            onChange={handleChange}
                        />
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
        <div dangerouslySetInnerHTML={{ __html: code}}/>
        );
    }
}

export default FakePay;