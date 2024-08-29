using Microsft.EntityFrameworkCore;

namespace EFCoreExample.Contexts

class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=Localhost;Database=EFCoreExample;Trusted_Connection=True");
        // options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
    }
}