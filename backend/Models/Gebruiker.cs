using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class Gebruiker : IdentityUser
{
    [Key]
    public int UserID {get; set;}

    [Required]
    public string Email {set; get;} = string.Empty;

    [Required]
    public string? Wachtwoord {set; get;} = string.Empty;

    // public List<Ticket>? tickets {set; get;}
}