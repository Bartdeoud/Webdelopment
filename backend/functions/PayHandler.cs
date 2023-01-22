public class PayHandler
{
    public static bool getPayResult(int gebruiker_id, bool paid, int TicketID)
    {
        using (var dB = new DBContext())
        {
            if (paid)
            {
                //Gebruiker gebruiker = GebruikerHandler.getGebruikerWithIDAsync(gebruiker_id);
                //Ticket addTicket = TicketHandler.getTicketWithId(TicketID);
                //gebruiker.tickets.Add(addTicket);
                return paid;
                //FirstOrDefaultAsync bestaat maar kan niet gevonden worden;
            }
            else
            {
                return false;
            }

        }
    }
}