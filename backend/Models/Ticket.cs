using System.ComponentModel.DataAnnotations;

public class Ticket
{
    [Key]
    public int TicketID {get; set;}

    [Required]
    public string stoelNr {set; get;}

    [Required]
    public string Email {set; get;}

    [Required]
    public string Wachtwoord {set; get;}
}