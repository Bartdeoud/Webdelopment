public static class GebruikerHandler
{
    public static DBContext dB;

    public static Gebruiker getGebruikerWithIDAsync(int gebruiker_id) {
        return dB.gebruikers.FirstOrDefault(gebruiker => gebruiker.UserID == gebruiker_id);
    }

    public async static Task<bool> updateGebruikerAsync(Gebruiker update)
    {
        try
        {
            dB.gebruikers.Update(update);
            
            return await dB.SaveChangesAsync() >= 1;
        }
        catch
        {
            return false;
        }
    }
    public async static Task<bool> deleteGebruikerAsync(int id)
    {
        try
        {
            Gebruiker gebruikerRemove =  getGebruikerWithIDAsync(id);
            dB.Remove(gebruikerRemove);
            return await dB.SaveChangesAsync() >= 1;
        }
        catch
        {
            return false;
        }
    } 
}
