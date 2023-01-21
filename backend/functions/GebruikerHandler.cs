public static class GebruikerHandler
{
    public static List<Gebruiker> getListGebruiker() 
    {
        using (var dB = new DBContext())
        {
            return dB.gebruikers.ToList();
            //ToListAsync kan niet gevonden worden;
        }
    }
    public static Gebruiker getGebruikerWithIDAsync(int gebruiker_id)
    {
        using (var dB = new DBContext())
        {
            return dB.gebruikers.FirstOrDefault(gebruiker => gebruiker.UserID == gebruiker_id);
            //FirstOrDefaultAsync bestaat maar kan niet gevonden worden;
        }
    }

    public async static Task<bool> addGebruikerAsync(Gebruiker new_gebruiker)
    {
        using (var dB = new DBContext())
        {
            try
            {
                await dB.gebruikers.AddAsync(new_gebruiker);
                return await dB.SaveChangesAsync() >= 1;
            }
            catch
            {
                return false;
            }
        }
    }
    public async static Task<bool> updateGebruikerAsync(Gebruiker update)
    {
        using (var dB = new DBContext())
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
    }
    public async static Task<bool> deleteGebruikerAsync(int id)
    {
        using (var dB = new DBContext())
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
    
}
