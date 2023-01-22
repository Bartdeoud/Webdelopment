using System.ComponentModel.DataAnnotations;
public class Stoelrij{
    [Key]
    public int IdStoelrij{get;set;}
    public int Rangnummer{get;set;}

    public int Aantal_stoelen{get;set;}=0;
}