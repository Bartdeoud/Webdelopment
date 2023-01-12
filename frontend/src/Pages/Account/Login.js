import React from 'react';
import Hero2 from '../Shared/Hero2';

function Login() {
  return(
    <>
        <Hero2 tekst="Inloggen"/>
        <form className="contact">
        <label>
            <p>Username</p>
            <input type="text" />
        </label>
        <label>
            <p>Password</p>
            <input type="password" />
        </label>
        <div>
            <button type="submit">Submit</button>
        </div>
        </form>
    </>
  )
}

export default Login;