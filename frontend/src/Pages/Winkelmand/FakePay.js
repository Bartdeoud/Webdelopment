import React, { useState } from 'react';
import { Form, Button } from 'react-bootstrap';

const FakePay = () => {
    var [amount , setAmount] = useState('');
    
    const handleSubmit = (e) => {
        e.preventDefault();
        const Order = {
            amount
        };
        handleOnSubmit(Order);
        console.log (Order);
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
            <div>
                <Form onSubmit={handleSubmit}>
                    <Form.Group controlId="name">
                        <Form.Label>amount</Form.Label>
                        <br/>
                        <Form.Control
                            type="number"
                            placeholder="Amount"
                            value={amount}
                            onChange={(e) => setAmount(e.target.value)}
                        />
                    </Form.Group>
                    <br/>
                    <Button type="submit"> Submit </Button>
                </Form>
            </div>
        )
    }else{
        return (
        <div dangerouslySetInnerHTML={{ __html: code}}/>
        );
    }
}

export default FakePay;