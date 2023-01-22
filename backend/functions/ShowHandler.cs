namespace backend;

public static class ShowHandler
{
    public static DBContext db = new DBContext();
    public static List<Show> GetEvenementen(){
        return db.shows.ToList();
    }

        public static Show GetShowByName(string naam){
        return db.shows.First(s => s.Naam.Equals(naam));
    }
}