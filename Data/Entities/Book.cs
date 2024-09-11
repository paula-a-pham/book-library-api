namespace Data.Entities;

public class Book
{
    public int BookId { get; set; }
    public required string Title { get; set; }
    public string? Summary { get; set; }
    public string? Language { get; set; }
    public string? Image { get; set; }
    public DateTime? PublicationDate { get; set; }
    public int? Pages { get; set; }
    public bool? Availability { get; set; }
}
