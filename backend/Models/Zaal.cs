using System.ComponentModel.DataAnnotations;

internal class Zaal {
    [Key]
    public int Zaalnr {get;set;}
    public string Naam {get;set;}
    public int Aantal_stoelen {get;set;}
    //public List<Rij> rijen {get;set;}
}