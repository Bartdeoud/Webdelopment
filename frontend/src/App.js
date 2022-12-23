// import './App.css';

// import Header from './Pages/Shared/Header';
// import Footer from './Pages/Shared/Footer';
// import Title from './Pages/Shared/Titel';
// import Main from './Main';

// function App() {
//     return (
//       <div>
//         <meta charSet="utf-8" />
//         <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
//         <meta name="viewport" content="width=device-width, initial-scale=1" />
//         <link rel="stylesheet" href="Assets/css/styles.css" />
//         <Header />
//         <Title />  
//         <Main />
//         <Footer />
//       </div>
//     );
//   }

// export default App;

import React from "react";
import { Routes, Route, BrowserRouter } from "react-router-dom";
import Home from "./Pages/Home/Home";
import About from "./Pages/OverOns/OverOns";
import Contact from "./Pages/Contact/Contact";
import Programma from "./Pages/Programma/Programma";
import Accesibility from "./Pages/Accesibility/Accesibility";
import Voorwaarden from "./Pages/Voorwaarden/Voorwaarden";

class App extends React.Component {
  render() {
    return (
      <BrowserRouter>
          <Routes>
            <Route exact path="/" element={<Home />} />
            <Route path="/Overons" element={<About />} />
            <Route path="/Contact" element={<Contact />} />
            <Route path="/Programma" element={<Programma />} />
            <Route path="/Accesibility" element={<Accesibility />} />
            <Route path="/Voorwaarden" element={<Voorwaarden />} />
          </Routes>
      </BrowserRouter>
    );
  }
}

export default App;