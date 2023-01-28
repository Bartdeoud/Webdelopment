using System.ComponentModel.DataAnnotations;

public class Leeftijdsgroep
{
    [Key]
    public int LeeftijdsgroepID { get; set; }
    public string Naam { get; set; }
}