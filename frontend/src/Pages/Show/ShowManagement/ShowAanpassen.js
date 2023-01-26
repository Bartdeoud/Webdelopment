import React, { useState, useEffect } from 'react';
import Hero2 from '../../Shared/Hero2';
import axios from 'axios';
import ShowBlock from './ShowBlock';
import NoShow from '../NoShow';

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
            <NoShow/>
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
                    tijd={(voorstelling.beginTijd).substring(11,15)}
                    LinkToImg={voorstelling.afbeelding}
                    leeftijdsgroep={voorstelling.leeftijdsgroep}
                    genre={voorstelling.genre}/>
                )}
            </div>
        )
    }
}

export default ShowAanpassen;