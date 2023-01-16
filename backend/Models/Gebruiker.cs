using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class Gebruiker: IdentityUser
{
    [Key]
    public int UserID {get; set;}

    [Required]
    [MaxLength (100)]
    public string Naam {set; get;}

    [Required]
    public string Email {set; get;}

    [Required]
    public string Wachtwoord {set; get;}

    public Ticket[] tickets {set; get;}
}