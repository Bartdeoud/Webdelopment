import React from 'react';
import Hero2 from '../Shared/Hero2';

export default function Login() {
  return(
    <>
        <Hero2 tekst="Inloggen"/>
        <form>
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