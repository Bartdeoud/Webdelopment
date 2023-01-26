using System.ComponentModel.DataAnnotations;

public class Zaal {
    [Key]
    public int Zaalnr {get;set;}
    public string Naam {get;set;}
    public int Rang1 {get;set;}
    public int? Rang2 {get;set;}
    public int? Rang3 {get;set;}
    public int? Rang4 {get;set;}
    public int? invalideplaatsen {get;set;}
}