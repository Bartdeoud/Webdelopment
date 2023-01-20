using System.ComponentModel.DataAnnotations;

public class Band
{
    [Key]
    public int IdBand { get; set; }
    public string Naam { get; set; }
    public string Omschrijving { get; set; }
    public string Afbeelding { get; set; }
}