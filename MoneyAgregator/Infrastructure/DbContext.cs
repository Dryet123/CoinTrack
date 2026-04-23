namespace MoneyAgregator.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MoneyAgregator.Core.Entity;

public class CurrencyDbContext : DbContext
{
    DbSet<CurrencyEntity> Currencies { get; set; }
    
}