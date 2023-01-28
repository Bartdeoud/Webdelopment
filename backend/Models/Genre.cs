using System.ComponentModel.DataAnnotations;

public class Genre
{
    [Key]
    public int GenreID { get; set; }
    public string Naam { get; set; }
}