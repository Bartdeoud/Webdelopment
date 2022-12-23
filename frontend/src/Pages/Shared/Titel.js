import React from "react";

const Titel = (props) => {
    const {titel = ""} = props
    return (
        <h1 className="title"> Laak Theater {titel} </h1>
    );
}

export default Titel;