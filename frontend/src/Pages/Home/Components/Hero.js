import React from "react";

const Hero = () => {
    return (
        <section className="hero">
                <div className="background-image" style={{backgroundImage: 'url(Assets/image/Curtain2.jpg)'}} />
                <a href="/Tickets" className="btn">Bestel hier uw Tickets!</a>
        </section>
    );
}

export default Hero;