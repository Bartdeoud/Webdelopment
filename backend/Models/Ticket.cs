using System.ComponentModel.DataAnnotations;

public class Ticket
{
    [Key]
    public int TicketID {get; set;}

    [Required]
    public string stoelNr {set; get;}
}