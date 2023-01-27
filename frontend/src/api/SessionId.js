import  {useEffect, useState} from "react";
import axios from "axios";

function GetSessionId(email, ticketData){
    const [posts, setPosts] = useState([])

    useEffect(() => {
        axios.get('https://localhost:7214/api/Pay/getSessionId?email=' + email + "&ticketData=" + ticketData)
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [email]);
    return posts;
    }

export default GetSessionId