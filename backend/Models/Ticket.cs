using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ticket
{
    [Key]
    public int TicketID {get; set;}

    [Required]
    public int stoelNr {set; get;}
    public int Rang {get; set;}
    public string? email {get; set;}
    
    [ForeignKey("Show")]
    public int Shownr {get;set;}
}