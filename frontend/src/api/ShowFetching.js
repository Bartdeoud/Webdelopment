import React, {useEffect, useState} from "react";
import axios from "axios";
import EvenementBlock from "../Pages/Programma/EvenementBlock.js"
import Alinea from "../Pages/Shared/Alinea.js"

function ShowFetching(){
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
            <Alinea titel="Geen voorstellingen gevonden"
            tekst="Herlaad de pagina of probeer het later opnieuw"/>
        )
    }else {
        return (
            <div>
                {posts.map(voorstelling =>
                <EvenementBlock 
                shownr={voorstelling.shownr}
                TitelVoorstelling={voorstelling.naam}
                zaal={voorstelling.zaal}
                datum={(voorstelling.beginTijd).substring(0,10)}
                tijd={(voorstelling.beginTijd).substring(11,15)}
                LinkToImg={voorstelling.afbeelding}/>
                )}
            </div>
        )
    }
}

export default ShowFetching