namespace backend;

public static class ShowHandler
{
    public static DBContext db = new DBContext();
    public static List<Show> GetShows(){
        return db.shows.ToList();
    }

    public static Show GetShowByName(string naam){
        return db.shows.First(s => s.Naam.Equals(naam));
    }

    public static void AddShow(Show show){
        db.shows.Add(show);
        db.SaveChanges();
    }

    public static int GetLastEvenementID(){
        return db.shows.Max(s => s.Shownr);
    }
}