using Data.Entities;
using Data.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new BookEntityTypeConfiguration().Configure(modelBuilder.Entity<Book>());
        new GenreEntityTypeConfiguration().Configure(modelBuilder.Entity<Genre>());
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }

}
