using Domain.Entity;
using Domain.Enumerables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Maps
{
    public class ProductsMapper : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .HasMaxLength(80)
                   .IsRequired();

            builder.Property(p => p.Description)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(p => p.Value)
                   .HasPrecision(18, 2)
                   .IsRequired();

            builder.Property(p => p.Classification)
                   .IsRequired()
                   .HasConversion<string>();

            builder.Property(p => p.Package)
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
}
