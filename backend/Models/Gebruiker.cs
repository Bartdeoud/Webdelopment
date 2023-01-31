using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class Gebruiker : IdentityUser
{
    [Required]
    public string Email {set; get;} = string.Empty;

    [Required]
    public string? Wachtwoord {set; get;} = string.Empty;

    public int TotaleDonatie { get; set; }

    // public List<Ticket>? tickets {set; get;}
}