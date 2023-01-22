import React, {useEffect, useState} from "react";
import axios from "axios";
import TicketBlok from "../Pages/Winkelmand/TicketBlok.js"

function GetEvenement(name, rang, aantal){
    const [posts, setPosts] = useState([])

    useEffect(() => {
        axios.get(('https://localhost:7214/api/Show/'+decodeURI(name)))
        .then(res => {
            console.log(res.data)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);

    return (
        <div>
           <TicketBlok TitelVoorstelling=
           {posts.Naam}
           Artiest={posts.Artiesten}
           zaal={posts.zaal}
           AantalTickets={aantal}
           rang={rang}
           LinkToImg={posts.Afbeelding}/>
        </div>
    )
}

export default GetEvenement