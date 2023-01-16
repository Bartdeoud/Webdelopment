using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class Ticket: IdentityUser
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