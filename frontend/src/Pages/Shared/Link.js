import React from "react";

// https://fontawesome.com/icons
const Link = (props) => {
    return (
        <li><a href="blank" target="_blank"><i className={props.icon}><p className="hidden">{props.tekst}</p></i></a></li>
    );
}

export default Link;