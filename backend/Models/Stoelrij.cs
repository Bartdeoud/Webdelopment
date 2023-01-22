using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Stoelrij{

    [Key]
    public int rijid{get;set;}
    public int Rangnummer{get;set;}

    public int Aantal_stoelen{get;set;}

    [ForeignKey("Zaal")]
    public int Zaalnr{get;set;}
}