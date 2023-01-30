using System.ComponentModel.DataAnnotations.Schema;
public class Leden
{
    public int Id { get; set; }
    
    [ForeignKey("Band")]
    public string BandId { get; set; }
    public List<Artiest> artiesten { get; set; }
}