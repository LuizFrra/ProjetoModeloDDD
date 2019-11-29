using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(k => k.ProductId);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(p => p.Available).HasDefaultValue(true).IsRequired(true);
            builder.Property(p => p.Value).IsRequired(true);
            builder.HasOne(p => p.Client).WithMany(p => p.Products).HasForeignKey(p => p.ClientId);
        }
    }
}
