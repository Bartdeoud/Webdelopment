using System.ComponentModel.DataAnnotations;
public class Show
{
    [Key]
    public int Shownr { get; set; }
    public string? Afbeelding { get; set; }
    public string? Genre { get; set; }
    public string Naam { get; set; } = "";
    public string? Leeftijdsgroep { get; set; }
    public string? zaal{get; set;}
    public DateTime BeginTijd { get; set; }
    public DateTime EindTijd { get; set; }
    public List<Artiest>? Artiesten {get;set;}
    //public DataTime[] Datums { get; set; }
}