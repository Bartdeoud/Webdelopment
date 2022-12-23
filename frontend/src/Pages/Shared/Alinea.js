import React from "react";

//const Alinea = ({titel, tekst}) => {
const Alinea = (props) => {
    const {titel, link} = props

    // below same as above
    // const titel = props.titel;
    // const tekst = props.tekst;

    return (
        <>
        <h3 className="title"> {titel} </h3>
        {/* props is no longer neccecary because of the destructuring */}
        <p> {props.tekst}</p>
        <a href="/">{link}</a>
        <br></br>
        <hr />
        </>
    );
}

export default Alinea;