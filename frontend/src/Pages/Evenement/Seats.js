import React from "react";
import Select from "react-dropdown-select";

function GetSeats() {
const options = [
    { 
      value: 1,
      label: "Sectie A"
    },
    {
      value:  2,
      label: "Sectie B"
    },
    {
      value:  3,
      label: "Sectie C"
    },
    {
      value:  4,
      label:  "Sectie D"
    },
    {
      value:  5,
      label: "Sectie E"
    },
    {
      value:  6,
      label: "Sectie F"
    }
  ]

  return(
    <div>
      <Select options={options} dropdownPosition="auto" onChange={(values) => console.log(values[0].value)} />
    </div>
  );
}

export default GetSeats;