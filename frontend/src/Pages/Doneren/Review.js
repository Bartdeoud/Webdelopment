import React, { useState, useEffect } from "react";
import Hero2 from "../Shared/Hero2";
import Cookies from "universal-cookie";
import PoorPeoplePage from "./PoorPeoplePage";
import axios from "../../api/axios";
import DonatieBlock from "./DonatieBlock";

const Review = () => {
    const [posts, setPosts] = useState([])
    const cookies = new Cookies(document.cookies);

    useEffect(() => {
        axios.get('https://localhost:7214/api/Show',
        {
            headers: cookies.get("Authorization"),
        })
        .then(res => {
            console.log(res)
            setPosts(res.data)
        })
        .catch(err =>{
            console.log(err)
        })
        // eslint-disable-next-line
    }, []);

    if (cookies === undefined){
        return(
            <PoorPeoplePage />
        );
    }else if (cookies.get("roles").includes('Donateur')){
        return(
            <>
                <Hero2 tekst="Review plaatsen" />

                {posts.map(voorstelling =>
                <DonatieBlock
                    shownr={voorstelling.shownr}
                    LinkToImg={voorstelling.afbeelding}
                    TitelVoorstelling={voorstelling.naam}
                    />
                )}
            </>
        );
    }else{
        return(
            <PoorPeoplePage />
        );
    }
}

export default Review;