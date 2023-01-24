using System.ComponentModel.DataAnnotations;

public class Ruimte
{
    [Key]
    public int RuimteNr { get; set; }
    public string Naam { get; set; }=null!;
    public int Capaciteit { get; set; }
}