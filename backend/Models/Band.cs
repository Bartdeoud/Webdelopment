using System.ComponentModel.DataAnnotations;

public class Band
{
    [Key]
    public int IdBand { get; set; }
    public string Naam { get; set; }=null!;
    public string Omschrijving { get; set; }=null!;
    public string Afbeelding { get; set; }=null!;
}