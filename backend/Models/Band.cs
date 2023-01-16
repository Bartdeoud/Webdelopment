using System.ComponentModel.DataAnnotations;

internal class Band
{
    [Key]
    public string Id { get; set; }
    public string Naam { get; set; }
    public string Omschrijving { get; set; }
    public string Afbeelding { get; set; }
}