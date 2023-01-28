using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Show
{
    [Key]
    public int Shownr { get; set; }
    public string? Afbeelding { get; set; }
    public string Naam { get; set; } = "";
    public DateTime BeginTijd { get; set; }
    public DateTime EindTijd { get; set; }

    [ForeignKey("Zaal")]
    public int? Zaal { get; set; }

    [ForeignKey("Genre")]
    public int? Genre { get; set; }
    
    [ForeignKey("Leeftijdsgroep")]
    public int? Leeftijdsgroep { get; set; }
}