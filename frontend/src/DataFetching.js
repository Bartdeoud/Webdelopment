import React, {useEffect, useState} from "react";
import axios from "axios";
import EvenementBlock from "./Pages/Programma/EvenementBlock.js"

function DataFetching(){
    const [posts, setPosts] = useState([])

    useEffect(() => {
        axios.get('https://localhost:7214/Evenement')
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);

    return (
        <div>
           {posts.map(voorstelling =>
           <EvenementBlock TitelVoorstelling=
           {voorstelling.TitelVoorstelling}
           Artiest={voorstelling.Artiest}
           zaal={voorstelling.zaal}
           datum={(voorstelling.dateTime).substring(0, 10)}
           tijd={(voorstelling.dateTime).substring(11, 16)}
           LinkToImg={voorstelling.LinkToImg}/>
           )}
        </div>
    )
}

export default DataFetching