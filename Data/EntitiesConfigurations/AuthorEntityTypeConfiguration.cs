using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntitiesConfigurations;

internal class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        // Select Max Length
        builder.Property(a => a.Name).HasMaxLength(150);
        builder.Property(a => a.Bio).HasMaxLength(1000);
        builder.Property(a => a.Nationality).HasMaxLength(20);
    }
}
