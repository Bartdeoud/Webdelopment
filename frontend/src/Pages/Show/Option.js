import React from "react";

const Option = (props) => {
    const {value, rang, naam} = props;

    if (rang === 0 || rang === null || rang === undefined){
        return(
            <option disabled value={value}>{naam} niet beschikbaar</option>
        );
    }else{
        return(
            <option value={value}>{naam}</option>
        );
    }
}

export default Option;