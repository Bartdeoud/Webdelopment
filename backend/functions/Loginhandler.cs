namespace backend;

public class Loginhandler{
    public static List<Gebruiker> gebruikers = new List<Gebruiker>();

    public static DBContext database;
    public static Random rnd = new Random();
    static public async void addUser(string naam, string wachtwoord, string email, string username){
        database.gebruikers.Add(new Gebruiker(){Email=email,Naam=naam,Username=username,Wachtwoord=wachtwoord,UserID=rnd.Next(0,2147483647)});
        database.SaveChanges();
    }
    static public async void addUser(string naam, string wachtwoord, string email){//If no username, username=naam
        addUser(naam, wachtwoord, email, naam);
    }

    static public Task<bool> checkLogin(string gebrnaam, string wwoord){

        var user = database.gebruikers
            .Where(g=>g.Username.Equals(gebrnaam) & g.Wachtwoord==wwoord)
            .Select(g=>new {g.UserID, g.Username, g.Wachtwoord})
            .ToList();

        if(user.Count()==1){
            return new Task<bool>(()=>true);
        }
        else{
            return new Task<bool>(()=>false);
        }
}