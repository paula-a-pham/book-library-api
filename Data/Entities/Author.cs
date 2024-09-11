namespace Data.Entities;

public class Author
{
    public int AuthorId { get; set; }
    public required string Name { get; set; }
    public string? Bio { get; set; }
    public string? Nationality { get; set; }
    public string? Image { get; set; }
    public DateTime? BirthDate { get; set; }
    public ICollection<Book>? Books { get; set; }
}
