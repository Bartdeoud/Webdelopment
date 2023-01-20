namespace backend;

public class EvenementHadler
{
    public static List<Evenement> Evenementen = new List<Evenement>();

    public EvenementHadler(){
        Evenementen.Add(
            new Evenement("Soldaat van oranje", "eensoldaat", DateTime.Now, "Zaal 2", "..\\assets\\image\\LaakZaal3.jpg")
        );
    }

    public List<Evenement> GetEvenementen(){
        return Evenementen;
    }
}