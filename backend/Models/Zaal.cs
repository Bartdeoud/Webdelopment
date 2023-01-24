using System.ComponentModel.DataAnnotations;

public class Zaal {
    [Key]
    public int Zaalnr {get;set;}
    public string Naam {get;set;}=null!;
    public int Aantal_stoelen {get;set;}
    
}