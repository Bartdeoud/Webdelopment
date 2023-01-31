import React, { useState } from "react";
import Hero2 from "../Shared/Hero2";
import Cookies from "universal-cookie";
import PoorPeoplePage from "./PoorPeoplePage";
import { useNavigate, useLocation } from "react-router-dom";

const ReviewToevoegen = () => {
    const cookies = new Cookies(document.cookies);
    const [review, setReview] = useState("");
    const navigate = useNavigate();
    const {state} = useLocation();
    const {TitelVoorstelling, shownr, LinkToImg} = state

    const handleSubmit = () => {
        handleOnSubmit();
        navigate('/Review');
        window.location.reload(false);
    }

    const handleOnSubmit = async (e) => {
        try {
            let res = await fetch("https://localhost:7214/api/Review", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                    "Authorization": cookies.get("Authorization")
                },
                body: JSON.stringify({
                    reviewId: 0,
                    show: shownr,
                    reviewtekst: review
                }),
            });
          if (res.status === 200) {
            console.log("succes");
        }
        } catch (err) {
            console.log(err);
        }
    }

    if (cookies === undefined){
        return(
            <PoorPeoplePage />
        );
    }else if (cookies.get("roles").includes('Donateur')){
        return(
            <>
                <Hero2 tekst="Review plaatsen" />

                <section className="programmaBlock">
                    <div className="Evenement">
                        <img src={LinkToImg} alt="Afbeelding evenement" width="40%" height="40%"></img>
                        <h1>{TitelVoorstelling}</h1>
                    </div>
                </section>

                <section className="contact">
                    <form onSubmit={handleSubmit}>
                        <p>Review:</p>
                        <input required placeholder="Shrijf hier uw review" name="Review" id="Review" onChange={(e) => setReview(e.target.value)}/>
                        <br/>
                        <button className="btn" type="submit">Review plaatsen</button>
                    </form>
                </section>
                
            </>
        );
    }else{
        return(
            <PoorPeoplePage />
        );
    }
}

export default ReviewToevoegen;