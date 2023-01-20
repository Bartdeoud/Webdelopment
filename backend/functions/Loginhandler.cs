namespace backend;

public class Loginhandler{
    public static Random rnd = new Random();
    public static DBContext database = new DBContext();
    static public async void addUser(String naam, String wachtwoord, String email, String username){
        database.Add(new Gebruiker(){Email=email,Naam=naam,Username=username,Wachtwoord=sha256(wachtwoord),UserID=rnd.Next(0,2147483647)});
        database.SaveChanges();
    }
    static public async void addUser(String naam, String wachtwoord, String email){//If no username, username=naam
        addUser(naam, wachtwoord, email, naam);
    }

    static public Boolean checkLogin(String username, String password){
        
        foreach(Gebruiker g in database.gebruikers){

        
            if(sha256(password)==g.Wachtwoord&&username==g.Username){
                return true;
            }
        }
        return false;
    }
    
    static string sha256(string input)
    {
        var crypt = new System.Security.Cryptography.SHA256Managed();
        var hash = new System.Text.StringBuilder();
        byte[] crypto = crypt.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
        foreach (byte theByte in crypto)
        {
            hash.Append(theByte.ToString("x2"));
        }
        return hash.ToString();
    }

}