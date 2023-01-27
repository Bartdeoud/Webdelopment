import React, {useEffect, useState} from "react";
import axios from "axios";
import EvenementBlock from "../Pages/Programma/EvenementBlock.js"
import Hero2 from "../Pages/Shared/Hero2.js"
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
            <>
            <Hero2 tekst="Geen shows gevonden "/>
            <Alinea titel="We konden helaas geen shows vinden."
                tekst="Herlaad de pagina of probeer het later opnieuw"/>
        </>
        )
    }else {
        return (
            <div>
                <Hero2 tekst="Programma"/>
                {posts.map(voorstelling =>
                <EvenementBlock 
                    shownr={voorstelling.shownr}
                    TitelVoorstelling={voorstelling.naam}
                    zaal={"Zaal " + voorstelling.zaal}
                    datum={(voorstelling.beginTijd).substring(0,10)}
                    tijd={(voorstelling.beginTijd).substring(11,16)}
                    LinkToImg={voorstelling.afbeelding}/>
                )}
            </div>
        )
    }
}

export default ShowFetching