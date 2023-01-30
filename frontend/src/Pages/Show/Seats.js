import React from "react";
import Select from "react-dropdown-select";
import Cookies from 'universal-cookie';

function Seats() {
const options = [
    { 
      value: 1,
      label: "Rang 1"
    },
    {
      value:  2,
      label: "Rang 2"
    },
    {
      value:  3,
      label: "Rang 3"
    }
  ]

  return(
    <>
      <p>Selecteer uw rang</p>
      <Select options={options} dropdownPosition="auto" onChange={(values) => {
        console.log(values)
        const cookies = new Cookies(document.cookies);
        cookies.set("tempRang", values[0].value);
        }} />
    </>
  );
}

export default Seats;