namespace MoneyAgregator.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MoneyAgregator.Core.Entity;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Currency> Currencies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CurencyConfiguration());
    }
    
}