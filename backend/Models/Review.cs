using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review {
    [Key]
    public int reviewId {get;set;}
    
    [ForeignKey("Show")]
    public int Show {get;set;}
    public string? reviewtekst {get;set;}
}