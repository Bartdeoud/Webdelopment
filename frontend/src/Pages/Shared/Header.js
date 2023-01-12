import { useState } from "react";

export default function Header() {
    const [isMenuOpen, setIsMenuOpen] = useState(false);

    return (
        <header>
            <nav className="navigation">
                <h3>&nbsp;<a href="/">Laaktheater</a></h3>
                <button className="icon" onClick={
                    () => { setIsMenuOpen(!isMenuOpen); }
                }
                ><i class="fa fa-bars"></i></button>
                <div className={isMenuOpen ? "menu open" : "menu"}>
                    <ul>
                        <li><a href="/">Home</a></li>
                        <li><a href="/Programma">Programma</a></li>
                        <li><a href="/OverOns">Over ons</a></li>
                        <li><a href="/OverOns">Huur</a></li>
                        <li><a href="/Account">Mijn account</a></li>
                        <li><a href="/Winkelmand"><i class="fa-solid fa-basket-shopping"></i></a></li>
                        <li><a href="/Accesibility"><i className="fa fa-wheelchair" /></a></li>
                    </ul>
                </div>
            </nav>
        </header>
    );
}
