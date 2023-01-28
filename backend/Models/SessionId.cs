using System.ComponentModel.DataAnnotations;
public class SessionId
{
    [Key]
    public string Session { get; set; }
    public DateTime expiration {get;set;}
    public string? ticketData{get;set;}
    public string? email {get;set;}
}