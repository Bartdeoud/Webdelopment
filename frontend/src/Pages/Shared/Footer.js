import React from "react";
import Link from "./Link";

const Footer = () => {         
    return (
            <footer>
                <p>Volg ons op:</p>
                <ul>
                    <Link icon="fa fa-twitter-square" tekst="Twitter pagina"/>
                    <Link icon="fa fa-facebook-square" tekst="Facebook pagina"/>
                    <Link icon="fa fa-snapchat-square" tekst="Snapchat pagina"/>
                    <Link icon="fa fa-youtube-square" tekst="Youtube pagina"/>
                    <Link icon="fa-brands fa-square-instagram" tekst="Instagram pagina"/>
                </ul> 
                <p>Made by <a href="https://github.com/Kikkerslijm410" target="_blank" rel="noreferrer">Shitshow inc</a></p>
                <p>Lees hier<a href="/Voorwaarden"> de algemene voorwaarden</a></p>
            </footer>
        );
    } 
export default Footer;