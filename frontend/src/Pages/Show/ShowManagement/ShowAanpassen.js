import React, { useState, useEffect } from 'react';
import Hero2 from '../../Shared/Hero2';
import axios from 'axios';
import ShowBlock from './ShowBlock';
import Alinea from '../../Shared/Alinea';

const ShowAanpassen = () => {
    const [posts, setPosts] = useState([])
    
    useEffect(() => {
        axios.get('https://localhost:7214/api/Show/')
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);

    if (posts.length === 0){
        return (
            <>
            <Hero2 tekst="Geen shows gevonden"/>
            <Alinea titel="We konden helaas geen shows vinden."
                tekst="Herlaad de pagina of probeer het later opnieuw"/>
        </>
        )
    }else {
        return (
            <div>
                <Hero2 tekst="Shows aanpassen"/>
                {posts.map(voorstelling =>
                <ShowBlock 
                    shownr={voorstelling.shownr}
                    TitelVoorstelling={voorstelling.naam}
                    zaal={voorstelling.zaal}
                    datum={(voorstelling.beginTijd).substring(0,10)}
                    tijd={(voorstelling.beginTijd).substring(11,16)}
                    LinkToImg={voorstelling.afbeelding}
                    leeftijdsgroep={voorstelling.leeftijdsgroep}
                    genre={voorstelling.genre}/>
                )}
            </div>
        )
    }
}

export default ShowAanpassen;