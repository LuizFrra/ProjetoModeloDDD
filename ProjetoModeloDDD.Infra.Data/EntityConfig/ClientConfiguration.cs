using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(p => p.ClientId);
            builder.Property(p => p.Email).IsRequired(true).HasMaxLength(40);
            builder.Property(p => p.Name).IsRequired(true).HasMaxLength(70);
            builder.Property(p => p.LastName).IsRequired(true).HasMaxLength(70);
            builder.Property(p => p.RegisterDate).IsRequired(true).ValueGeneratedOnAdd().HasDefaultValueSql("NOW()");
        }
    }
}
