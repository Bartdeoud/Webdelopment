import React, { Component } from "react";
import Hero2 from "../Shared/Hero2";
import DataFetching from "../../DataFetching.js";

class Programma extends Component {
    constructor(props) {
        super(props);
        this.state = {
            data: null,
        };
    }

    render () {
        return(
            <>
                <Hero2 tekst="Programma"/>
                <DataFetching/>
            </>
            
        );
    }
}

export default Programma;