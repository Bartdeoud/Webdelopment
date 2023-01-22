import React, {useEffect, useState} from "react";
import axios from "axios";
import EvenementBlock from "../Pages/Programma/EvenementBlock.js"

function DataFetching(){
    const [posts, setPosts] = useState([])

    useEffect(() => {
        axios.get('https://localhost:7214/api/Show/0')
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
           {voorstelling.Naam}
           Artiest="tja"
           zaal={voorstelling.zaal}
           datum={(voorstelling.BeginTijd).substring(0, 10)}
           tijd={(voorstelling.BeginTijd).substring(11, 16)}
           LinkToImg={voorstelling.Afbeelding}/>
           )}
        </div>
    )
}

export default DataFetching