using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntityConfig;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext(DbContextOptions<ProjetoModeloContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Model.GetEntityTypes().SelectMany(t => t.GetProperties().Where(p => p.ClrType == typeof(string))).ToList().ForEach(p => {
                p.SetMaxLength(20);
            });

            builder.Entity<Client>().ToTable("tbl_clients");
            builder.Entity<Product>().ToTable("tbl_products");

            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
