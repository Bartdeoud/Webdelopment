import React, {useEffect, useState} from "react";
import axios from "axios";
import TicketBlok from "../Pages/Winkelmand/TicketBlok.js"

function GetEvenement(id, rang, aantal){
    const [posts, setPosts] = useState([])
    useEffect(() => {
        axios.get(('https://localhost:7214/api/Show/' + id))
        .then(res => {
            console.log(res.data)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
            
        })
    }, );

    return (
        <div>
           <TicketBlok 
           TitelVoorstelling={posts.naam}
           zaal={posts.zaal}
           AantalTickets={aantal}
           rang={rang}
           LinkToImg={posts.afbeelding}/>
        </div>
    )
}

export default GetEvenement