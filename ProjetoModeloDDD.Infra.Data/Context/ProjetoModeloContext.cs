using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext(DbContextOptions<ProjetoModeloContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

    }
}
