public class GebruikerHandler
{
    public async static Task<string> getGebruikerWithIDAsync(string gebruiker_id)
    {
        using (var dB = new DBContext())
        {
            //return await dB.gebruikers.FirstOrDefault(gebruiker => gebruiker.UserID == gebruiker_id);
            return "true";
        }
    }

    public async static Task<bool> addGebruikerAsync(Gebruiker new_gebruiker)
    {
        using (var dB = new DBContext())
        {
            try
            {
                await dB.AddAsync(new_gebruiker);
                return await dB.SaveChangesAsync() >= 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
