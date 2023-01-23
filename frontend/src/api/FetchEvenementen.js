import React, {useEffect, useState} from "react";
import axios from "axios";
import EvenementBlock from "../Pages/Programma/EvenementBlock.js"

function DataFetching(){
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

    return (
        <div>
           {posts.map(voorstelling =>
           <EvenementBlock TitelVoorstelling=
           {voorstelling.naam}
           zaal={voorstelling.zaal}
           datum={(voorstelling.beginTijd).substring(0,10)}
           tijd={(voorstelling.beginTijd).substring(11,15)}
           LinkToImg={voorstelling.afbeelding}/>
           )}
        </div>
    )
}

export default DataFetching