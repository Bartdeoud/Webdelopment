import React from "react";
import { Routes, Route, BrowserRouter } from "react-router-dom";
import Home from "./Pages/Home/Home";
import About from "./Pages/OverOns/OverOns";
import Winkelmand from "./Pages/Winkelmand/Winkelmand";
import Huren from "./Pages/Winkelmand/Huren";
import Programma from "./Pages/Programma/Programma";
import Accesibility from "./Pages/Accesibility/Accesibility";
import Voorwaarden from "./Pages/Voorwaarden/Voorwaarden";
import VierNulVier from "./Pages/404/404";
import Login from "./Pages/Account/Login";
import Account from "./Pages/Account/Account";
import Aanmaken from "./Pages/Account/Aanmaken";
import ShowToevoegen from "./Pages/Show/ShowManagement/ShowToevoegen";
import ShowAanpassen from "./Pages/Show/ShowManagement/ShowAanpassen";
import ShowChanger from "./Pages/Show/ShowManagement/ShowChanger";
import Show from "./Pages/Show/Show";
import Ticket from "./Pages/Ticket/Ticket";
import ZaalToevoegen from "./Pages/Zaal/ZaalToevoegen";
import ZaalAanpassen from "./Pages/Zaal/ZaalAanpassen";
import ZaalChanger from "./Pages/Zaal/ZaalChanger";
import Redirect from "./Pages/Winkelmand/redirect";
import Doneren from "./Pages/Doneren/Doneren.js";
import BegunstigersPortaal from "./Pages/Doneren/BegunstigersPortaal.js";
import Review from "./Pages/Doneren/Review.js";
import ReviewToevoegen from "./Pages/Doneren/ReviewToevoegen.js";

class Main extends React.Component {
  render() {
    return (
      <BrowserRouter>
          <Routes>
            <Route exact path="/" element={<Home />} />
            <Route path="/Overons" element={<About />} />
            <Route path="/Winkelmand" element={<Winkelmand />} />
            <Route path="/Programma" element={<Programma />} />
            <Route path="/Show" element={<Show/>} />
            <Route path="/Accesibility" element={<Accesibility />} />
            <Route path="/Voorwaarden" element={<Voorwaarden />} />
            <Route path="/Login" element={<Login />} />
            <Route path="/Account" element={<Account />} />
            <Route path="/Aanmaken" element={<Aanmaken />} />
            <Route path="/ShowToevoegen" element={<ShowToevoegen />} />
            <Route path="/Huren" element={<Huren />} />
            <Route path="/Doneren" element={<Doneren />} />
            <Route path="/BegunstigersPortaal" element={<BegunstigersPortaal />} />
            <Route path="/Review" element={<Review />} />
            <Route path="/ReviewToevoegen" element={<ReviewToevoegen />} />
            <Route path="/ShowAanpassen" element={<ShowAanpassen />} />
            <Route path="/ShowChanger" element={<ShowChanger />} />
            <Route path="/Ticket" element={<Ticket />} />
            <Route path="/ZaalToevoegen" element={<ZaalToevoegen />} />
            <Route path="/ZaalAanpassen" element={<ZaalAanpassen />} />
            <Route path="/ZaalChanger" element={<ZaalChanger />} />
            <Route path="/redirect" element={<Redirect/>} />
            <Route path="*" element={<VierNulVier />} />
          </Routes>
      </BrowserRouter>
    );
  }
}

export default Main;