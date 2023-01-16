using System.ComponentModel.DataAnnotations.Schema;
internal class Leden
{
    public string Id { get; set; }
    [ForeignKey("Band")]
    public string BandId { get; set; }
    public List<Artiest> artiesten { get; set; }
}