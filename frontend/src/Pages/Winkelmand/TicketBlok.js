import React from "react";

const TicketBlok = (props) => {
    const {
        TitelVoorstelling,
        Artiest,
        zaal,
        AantalTickets,
        rang,
        LinkToImg
    } = props

    return (
        <section className="programmaBlock">
                <div className="evenementblock">
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
                        <h3>rang: {rang}</h3>
                        <h3>Aantal tickets: {AantalTickets}</h3>
                        <br/>
                    </div>
                </div>      
        </section>
    );
}

export default TicketBlok;