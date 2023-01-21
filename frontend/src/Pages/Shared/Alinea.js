import React from "react";

//const Alinea = ({titel, tekst}) => {
const Alinea = (props) => {
    const {titel, link, linknaam, link2, linknaam2, tekst2} = props

    // below same as above
    // const titel = props.titel;
    // const tekst = props.tekst;

    return (
        <section className="contact">
            <h3 className="title"> {titel} </h3>
            {/* props is no longer neccecary because of the destructuring */}
            
            <p> {props.tekst} 
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