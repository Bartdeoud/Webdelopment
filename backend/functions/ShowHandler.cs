namespace backend;

public class ShowHandler
{
    public static List<Show> Show = new List<Show>();

    public ShowHandler(){
        Show.Clear();
        Show.Add(new Show{Naam = "Soldaat van orangje", dateTime = DateTime.Now, zaal = "Zaal 2", LinkToImg =  "..\\assets\\image\\LaakZaal3.jpg"});
        Show.Add(new Show{Naam = "Soldaat van orangje2", dateTime = DateTime.Now, zaal = "Zaal 2", LinkToImg =  "..\\assets\\image\\LaakZaal2.jpg"});
    }
    public List<Show> GetShows(){
        return Show;
    }
}