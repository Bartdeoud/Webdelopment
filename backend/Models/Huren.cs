using System.ComponentModel.DataAnnotations.Schema;

public class Huren
{
    public string Id { get; set; }=null!;
    public DateTime Datum { get; set; }
    //[ForeignKey("")]
    public string VerhuurdeId { get; set; }=null!;
}