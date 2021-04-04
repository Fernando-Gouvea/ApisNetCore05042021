using Microsoft.EntityFrameworkCore;
using ProjApiCliente.Models;

namespace ProjApiCliente.Context
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext>options):base(options)
        {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
            .HasOne(c => c.Endereco);
            base.OnModelCreating(modelBuilder);

        }

        
        
    }
}