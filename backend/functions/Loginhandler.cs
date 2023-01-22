namespace backend;

public class Loginhandler{
    public static List<Gebruiker> gebruikers = new List<Gebruiker>();

    /*public Loginhandler(){
        gebruikers.add
    }*/


    public static Random rnd = new Random();
    public static DBContext database = new DBContext();
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
        /*foreach(Gebruiker g in database.gebruikers){

        
            if(password==g.Wachtwoord&&username==g.Username){
                return new Task<bool>(()=>true);
            }
        }
        return new Task<bool>(()=>false);*/
    }
    
    /*static string sha256(string input)
    {
        var crypt = new System.Security.Cryptography.SHA256Managed();
        var hash = new System.Text.StringBuilder();
        byte[] crypto = crypt.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
        foreach (byte theByte in crypto)
        {
            hash.Append(theByte.ToString("x2"));
        }
        return hash.ToString();
    }*/

}