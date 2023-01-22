import React from "react";

const Alinea = (props) => {
    const {tekst, titel, link, linknaam, link2, linknaam2, tekst2} = props

    return (
        <section className="contact">
            <h3 className="title"> {titel} </h3>
            
            <p> {tekst} 
            <br></br>
            <a href= {link} > {linknaam} </a></p>
            
            <p> {tekst2} 
            <br></br>
            <a href= {link2} > {linknaam2} </a> </p>
            
            <br></br>
            <hr />
        </section>
    );
}

export default Alinea;