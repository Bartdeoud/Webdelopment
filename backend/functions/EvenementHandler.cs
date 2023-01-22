namespace backend;

public class EvenementHadler
{
    public static List<Evenement> Evenementen = new List<Evenement>();

    public EvenementHadler(){
        Evenementen.Clear();
        Evenementen.Add(new Evenement{TitelVoorstelling = "Soldaat van orangje", Artiest = "eensoldaat", dateTime = DateTime.Now, zaal = "Zaal 2", LinkToImg =  "..\\assets\\image\\LaakZaal3.jpg"});
        Evenementen.Add(new Evenement{TitelVoorstelling = "Soldaat van orangje2", Artiest = "eensoldaat", dateTime = DateTime.Now, zaal = "Zaal 2", LinkToImg =  "..\\assets\\image\\LaakZaal2.jpg"});
    }
    public List<Evenement> GetEvenementen(){
        return Evenementen;
    }
}