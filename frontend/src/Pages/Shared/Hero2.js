import React from "react";

const Hero2 = (props) => {
    const tekst = props.tekst;
    return (
        <section className="hero2">
                <div alt="Theater doek als achtergrond" className="background-image" style={{backgroundImage: 'url(assets/image/Curtain.jpg)'}} />
                <h1>{tekst}</h1>
        </section>
    );
}

export default Hero2;