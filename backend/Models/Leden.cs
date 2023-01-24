using System.ComponentModel.DataAnnotations.Schema;
public class Leden
{
    public string Id { get; set; }=null!;
    [ForeignKey("Band")]
    public string BandId { get; set; }=null!;
    public List<Artiest> artiesten { get; set; }=null!;
}