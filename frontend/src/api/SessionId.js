import  {useEffect, useState} from "react";
import axios from "axios";

function GetSessionId(email){
    const [posts, setPosts] = useState([])

    useEffect(() => {
        axios.get('https://localhost:7214/api/Pay/getSessionId?email=' + email)
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, []);
    return posts;
    }


export default GetSessionId