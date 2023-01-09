import React from "react";

const Header = () => {         
return (
        <header>
            <h3>&nbsp;<a href="/">Laaktheater</a></h3>
            <nav class="headerClass">
                <a href="/">Home</a>
                <a href="/Programma">Programma</a>
                <a href="/OverOns">Over ons</a>
                <a href="/Contact"><i class="fa-solid fa-basket-shopping"></i></a>
                <a href="/Accesibility"><i className="fa fa-wheelchair" /></a>
                <a class="icon" onclick="buttonClick()"><i class="fa fa-bars"></i></a>
            </nav>        
        </header>
    );
} 
function buttonClick(){
    var x = document.getElementById("headerLinks");
    if (x.className === "headerClass") {
        x.className += " responsive";
      } else {
        x.className = "header";
      }
}
export default Header;