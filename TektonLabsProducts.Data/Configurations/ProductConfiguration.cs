using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TektonLabsProducts.Core.Models;

namespace TektonLabsProducts.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(a => a.Id);
                
            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.Price)
                .IsRequired();
                
            builder
                .Property(m => m.InStock)
                .IsRequired();

            builder
                .ToTable("Products");
        }
    }
}