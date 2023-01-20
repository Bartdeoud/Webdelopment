import React, { Component } from "react";
import EvenementValues from "./EvenementValues.js";
import GetSeats from "./Seats.js";

class Programma extends Component {
    constructor(props) {
        super(props);

        this.handleSubmit = {

        }
        this.state = {
            textInput: null,
        };
    }

    render () {
        return(
            <div className="EvenementPagina">
                <EvenementValues/>
                <GetSeats></GetSeats>
                <form onSubmit={this.handleSubmit}>
                <label>
                    Aantal kaartjes (0-9):
                    <input type="text" ref={this.textInput} />
                </label>
                    <br/>
                    <br/>
                    <button className="btn" type="button" onClick={""}>Submit</button>
                    <br/>
                    <br/>
                </form>
            </div>
        );
    }
}

export default Programma;