import { render, screen } from '@testing-library/react';
import Alinea from './Pages/Shared/Alinea';

test('renders alinea test tekst1', () => {
    render(<Alinea tekst="test" />);
    const linkElement = screen.getByText(/test/i);
    expect(linkElement).toBeInTheDocument();
    });

