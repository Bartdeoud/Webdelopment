import React from "react";
import Hero from "./Components/Hero";

class Home extends Component {
    constructor(props) {
        super(props);
        this.state = {
            data: null,
        };
    }
    render () {
        return(
            <>
                <Hero />
            </>
        );
    }
}

export default Home;