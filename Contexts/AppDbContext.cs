using AspCoreExemplo.EntityConfigs;
using AspCoreExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspCoreExemplo.Contexts;

class AppDbContext : DbContext
{
    // public DbSet<Cliente> clientes { get; set; } = null!;
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Produto> Produtos => Set<Produto>();
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample2;Trusted_Connection=True;");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration<Cliente>(new ClienteEntityConfig());
    }
}