import React from "react";

const Lijst = (props) => {
    const {titel, tekst, tekst2, item1, item2, item3, item4, item5, item6, item7} = props

    return (
        <section className="contact">
            <h3 className="title"> {titel} </h3>
            <p> {tekst} 
                <ul>
                    <il>{item1}</il><br/><br/>
                    <il>{item2}</il><br/><br/>
                    <il>{item3}</il><br/><br/>
                    <il>{item4}</il><br/><br/>
                    <il>{item5}</il><br/><br/>
                    <il>{item6}</il><br/><br/>
                    <il>{item7}</il>
                </ul>
                {tekst2}
            </p>
            <br/>
            <hr/>
        </section>
    );
}

export default Lijst;