import  {useEffect, useState} from "react";
import axios from "axios";

async function GetSessionId(email, ticketData){
    const [posts, setPosts] = useState([])

   useEffect(async () => {
        await axios.get('https://localhost:7214/api/Pay/getSessionId?email=' + email + "&ticketData=" + ticketData)
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [email, ticketData]);
    return posts;
}

export default GetSessionId