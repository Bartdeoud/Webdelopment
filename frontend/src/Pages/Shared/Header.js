import React from "react";

const Header = () => {         
return (
        <header>
            <h3>&nbsp;Laaktheater</h3>
            <nav>
            <li><a href="/">Home</a></li>
            <li><a href="/Programma">Programma</a></li>
            <li><a href="/OverOns">Over ons</a></li>
            <li><a href="/Winkelmand"><i class="fa-solid fa-basket-shopping"></i></a></li>
            <li><a href="/Accesibility"><i className="fa fa-wheelchair" /></a></li>
            </nav>
        </header>
    );
} 
export default Header;