import React from "react";

const Evenement = (props) => {
    const {
        TitelVoorstelling,
        Artiest,
        zaal,
        LinkToEv,
        LinkToImg
    } = props

    return (
        <section className="programmaBlock">
                <div class="evenement">
                    <div>
                        <img src={LinkToImg} alt="Afbeelding evenement" width="100%" height="100%"></img>
                    </div>

                    <div>
                        <h2>{TitelVoorstelling}</h2>
                        <br></br>
                        <h3>{Artiest}</h3>
                        <h3>{zaal}</h3>
                    </div>

                    <div id="bestel">
                        <h3>datum</h3>
                        <h3>tijd</h3>
                        <br/>
                        <a href={LinkToEv} className="btn">Bestel</a>
                    </div>
                </div>
        </section>
    );
}

export default Evenement;