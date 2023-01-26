import React, { useState } from "react";

const Header = () => {
    const [isMenuOpen, setIsMenuOpen] = useState(false);

    return (
        <header>
            <nav className="navigation">
                <h3>&nbsp;<a href="/">Laaktheater</a></h3>
                <button className="icon" onClick={
                    () => { setIsMenuOpen(!isMenuOpen); }
                }
                ><i className="fa fa-bars"></i></button>
                <div className={isMenuOpen ? "menu open" : "menu"}>
                    <ul>
                        <li><a href="/">Home</a></li>
                        <li><a href="/Programma">Programma</a></li>
                        <li><a href="/OverOns">Over ons</a></li>
                        <li><a href="/Huren">Huur</a></li>
                        <li><a href="/Account"><i className="fa-solid fa-circle-user"/></a></li>
                        <li><a href="/Winkelmand"><i className="fa-solid fa-basket-shopping"/></a></li>
                        <li><a href="/Accesibility"><i className="fa fa-wheelchair" /></a></li>
                    </ul>
                </div>
            </nav>
        </header>
    );
}

export default Header;
