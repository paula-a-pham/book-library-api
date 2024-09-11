using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntitiesConfigurations
{
    internal class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // Select Max Length
            builder.Property(b => b.Title).HasMaxLength(100);
            builder.Property(b => b.Summary).HasMaxLength(2000);
            builder.Property(b => b.Language).HasMaxLength(20);            
        }
    }
}
