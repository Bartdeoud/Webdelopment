using System.ComponentModel.DataAnnotations;

internal class Ruimte
{
    [Key]
    public int RuimteNr { get; set; }
    public string Naam { get; set; }
    public int Capaciteit { get; set; }
}