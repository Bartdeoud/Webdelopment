import React from "react";

const Hero = () => {
    return (
        <section className="hero">
            <div alt="Theater doek als achtergrond" className="background-image" style={{backgroundImage: 'url(assets/image/Curtain.jpg)'}} />
            <a href="/Programma" className="btn">Bestel hier uw Tickets!</a>
        </section>
    );
}

export default Hero;