import React from 'react';
import Hero2 from '../Shared/Hero2';

export default function Aanmaken() {
  return(
    <>
        <Hero2 tekst="Account aanmaken"/>
        <form>
        <label>
            <p>Username</p>
            <input type="text" />
        </label>
        <label>
            <p>Password</p>
            <input type="password" />
        </label>
        <label>
            <p>Geboortedatum</p>
            <input type="date" />
        </label>
        <label>
            <p>Email</p>
            <input type="email" />
        </label>
        <div>
            <button type="submit">Submit</button>
        </div>
        </form>
    </>
  )
}