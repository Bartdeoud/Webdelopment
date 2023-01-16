using System.ComponentModel.DataAnnotations.Schema;

internal class Huren
{
    public string Id { get; set; }
    public DateTime Datum { get; set; }
    //[ForeignKey("")]
    public string VerhuurdeId { get; set; }
}