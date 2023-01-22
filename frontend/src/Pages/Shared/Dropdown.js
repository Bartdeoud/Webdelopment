import React from "react";

//doesnt work the way i want it to
const Dropdown = (props) => {
    const {tekst, tekst2, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, naam1, naam2, naam3, naam4, naam5, naam6, naam7, naam8, naam9, naam10, change} = props

    return (
        <>
            <p>{tekst}</p>
            <select required="required" onChange={{change}}>
                <option value="" disabled selected>{tekst2}</option>
                <option value={item1}>{naam1}</option>
                <option value={item2}>{naam2}</option>
                <option value={item3}>{naam3}</option>
                <option value={item4}>{naam4}</option>
                <option value={item5}>{naam5}</option>
                <option value={item6}>{naam6}</option>
                <option value={item7}>{naam7}</option>
                <option value={item8}>{naam8}</option>
                <option value={item9}>{naam9}</option>
                <option value={item10}>{naam10}</option>
            </select>
        </>
    );
}

export default Dropdown;