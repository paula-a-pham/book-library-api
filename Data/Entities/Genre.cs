namespace Data.Entities;

public class Genre
{
    public int GenreId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
