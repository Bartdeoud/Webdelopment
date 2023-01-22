import React from "react";

const Lijst = (props) => {
    const {titel, tekst, tekst2, item1, item2, item3, item4, item5, item6, item7} = props

    return (
        <section className="contact">
            <h3 className="title"> {titel} </h3>
            <p> {tekst} 
                <ul>
                    <li>{item1}</li><br/>
                    <li>{item2}</li><br/>
                    <li>{item3}</li><br/>
                    <li>{item4}</li><br/>
                    <li>{item5}</li><br/>
                    <li>{item6}</li><br/>
                    <li>{item7}</li>
                </ul>
                {tekst2}
            </p>
            <br/>
            <hr/>
        </section>
    );
}

export default Lijst;