import React from "react";

const Hero = () => {
    return (
        <section className="hero">
                <div className="background-image" style={{backgroundImage: 'url(assets/image/Curtain.jpg)'}} />
                <a href="/Tickets" className="btn">Bestel hier uw kaarten!</a>
        </section>
    );
}

export default Hero;