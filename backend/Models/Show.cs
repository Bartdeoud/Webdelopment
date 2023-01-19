using System.ComponentModel.DataAnnotations;
public class Show
{
    [Key]
    public int Shownr { get; set; }
    public string Afbeelding { get; set; }
    public string Genre { get; set; }
    public string Naam { get; set; }
    public string Leeftijdsgroep { get; set; }
    public int BeginTijd { get; set; }
    public int EindTijd { get; set; }
    //public DataTime[] Datums { get; set; }
}