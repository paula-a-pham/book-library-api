using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntitiesConfigurations;

internal class GenreEntityTypeConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        // Select Max Length
        builder.Property(g => g.Name).HasMaxLength(255);
        builder.Property(g => g.Description).HasMaxLength(1000);
    }
}
