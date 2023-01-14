import { render, screen } from '@testing-library/react';
import App from './App';
import Hero2 from './Pages/Shared/Hero2';

test('Renders app and checks the output', () => {
  render(<App />);
  const linkElement = screen.getByText(/Dit is een tekst/i);
  expect(linkElement).toBeInTheDocument();
});
