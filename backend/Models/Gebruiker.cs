using System.ComponentModel.DataAnnotations;

public class Gebruiker
{
    [Key]
    public int UserID {get; set;}

    [Required]
    [MaxLength (100)]
    public string Naam {set; get;} = string.Empty;

    [Required]
    public string Email {set; get;} = string.Empty;

    [Required]
    public string Wachtwoord {set; get;} = string.Empty;

    public List<Ticket>? tickets {set; get;}
}