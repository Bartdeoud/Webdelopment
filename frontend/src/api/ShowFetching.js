import React, {useEffect, useState} from "react";
import axios from "axios";
import EvenementBlock from "../Pages/Programma/EvenementBlock.js"
import Hero2 from "../Pages/Shared/Hero2.js"
import Alinea from "../Pages/Shared/Alinea.js"
import Cookies from 'universal-cookie';

function ShowFetching(){
    const [posts, setPosts] = useState([])
    const cookies = new Cookies(document.cookies);

    useEffect(() => {
        axios.get('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net:7071/api/Show/',
        {
            headers: cookies.get("Authorization"),
        })
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
        // eslint-disable-next-line
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