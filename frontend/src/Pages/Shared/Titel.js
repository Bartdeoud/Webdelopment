import React from "react";

const Titel = (props) => {
    const {titel = ""} = props
    return (
        <h1 className="title"> {titel} </h1>
    );
}

export default Titel;