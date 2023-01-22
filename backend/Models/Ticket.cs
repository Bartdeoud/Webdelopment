using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ticket
{
    [Key]
    public int TicketID {get; set;}

    [Required]
    public string stoelNr {set; get;}
    
    [ForeignKey("Show")]
    public int Shownr {get;set;}
}