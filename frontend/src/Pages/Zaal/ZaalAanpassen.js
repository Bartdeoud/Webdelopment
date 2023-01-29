import React, { useState, useEffect } from 'react';
import axios from '../../api/axios';
import Hero2 from '../Shared/Hero2';
import ZaalBlock from './ZaalBlock';
import Alinea from '../Shared/Alinea';

const ZaalAanpassen = () => {
    const [posts, setPosts] = useState([])
    
    useEffect(() => {
        axios.get('https://localhost:7214/api/Zaal/')
        .then(res => {
            console.log(res)
            setPosts(res.data)
            console.log()
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);

    if (posts.length === 0){
        return (
            <>
            <Hero2 tekst="Geen zalen gevonden"/>
            <Alinea titel="We konden helaas geen zalen vinden."
                tekst="Herlaad de pagina of probeer het later opnieuw"/>
        </>
        )
    }else {
        return (
            <div>
                <Hero2 tekst="Zalen aanpassen"/>
                {posts.map(zaal =>
                    <ZaalBlock 
                        zaalnr={zaal.zaalnr}
                        Zaalnaam={zaal.naam}
                        Rang1={zaal.rang1}
                        Rang2={zaal.rang2}
                        Rang3={zaal.rang3}
                        Rang4={zaal.rang4}
                        invalideplaatsen={zaal.invalideplaatsen}
                        />
                )}
            </div>
        )
    }
}

export default ZaalAanpassen;