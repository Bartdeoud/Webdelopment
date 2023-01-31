import React from "react";
import Hero2 from "../Shared/Hero2";
import Cookies from "universal-cookie";
import PoorPeoplePage from "./PoorPeoplePage";
import { Navigate, useLocation } from "react-router-dom";

const ReviewToevoegen = () => {
    const cookies = new Cookies(document.cookies);
    const {state} = useLocation();
    const {
        TitelVoorstelling,
        shownr,
        LinkToImg
    } = state

    const handleSubmit = (e) => {
        handleOnSubmit();
        Navigate("/BegunstigersPortaal");
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
                    reviewtekst: e.target.Review.value,
                    show: shownr
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
    }else if (cookies.get("roles")[0] === 'Donateur'){
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
                        <textarea name="Review" id="Review" cols="30" rows="10"></textarea>
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