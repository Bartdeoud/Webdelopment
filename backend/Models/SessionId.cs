using System.ComponentModel.DataAnnotations;
public class SessionId
{
    [Key]
    public string Session { get; set; }
    public string email {get;set;}
}