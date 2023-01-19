import React, {useEffect, useState} from "react";
import axios from "axios";
import { useState } from "react";

function DataFetching(){
    const [posts, setPosts] = useState([])

    useEffect(() => {
        axios.get('https://localhost:7214/evenementen')
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
    }, [])

    return (
        <div>
           <p>{posts}</p>
        </div>
    )
}

export default DataFetching