import React, { useState } from "react";

const Header = () => {
    const [isMenuOpen, setIsMenuOpen] = useState(false);
    
    // Hier denk een check toevoegen zodat mensen die niet ingelogd zijn een andere header te zien krijgen
    
    return (
        <header>
            <nav className="navigation">
                <h3>&nbsp;<a href="/">Laaktheater</a></h3>
                <button className="icon" onClick={
                    () => { setIsMenuOpen(!isMenuOpen); }
                }
                ><i className="fa fa-bars"/><p className="hidden">Menu</p></button>
                <div className={isMenuOpen ? "menu open" : "menu"}>
                    <ul>
                        <li><a href="/Programma">Programma</a></li>
                        <li><a href="/OverOns">Over ons</a></li>
                        <li><a href="/Huren">Huur</a></li>
                        <li><a href="/Account"><i className="fa-solid fa-circle-user"><p className="hidden">Account</p></i></a></li>
                        <li><a href="/Winkelmand"><i className="fa-solid fa-basket-shopping"><p className="hidden">Winkelmand</p></i></a></li>
                        <li><a href="/Accesibility"><i className="fa fa-wheelchair"><p className="hidden">Toegankelijkheid</p></i></a></li>
                    </ul>
                </div>
            </nav>
        </header>
    );
}

export default Header;
