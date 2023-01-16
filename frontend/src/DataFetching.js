import React, {useEffect} from "react";
import axios from "axios";

function DataFetching(){
    const [posts, setPosts] = useState([])

    useEffect(() => {
        axios.get('https://localhost:7214/WeatherForecast')
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