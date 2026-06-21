using MoneyAgregator.Core.Entity;
using MoneyAgregator.Core.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace MoneyAgregator.Infrastructure;

public class CurrencyRepository : ICurrencyRepository
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<CurrencyRepository> _logger;

    public CurrencyRepository(AppDbContext dbContext,  ILogger<CurrencyRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public Task<List<Currency>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Currency> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Currency entity)
    {
        bool exists = _dbContext.Currencies.Any(c => c.Code == entity.Code && c.CurrencyCode == entity.CurrencyCode);
        if (exists)
        {
            _logger.LogError("Currencies with the same currency code already exists!");
            
        }
        else
        {
             _dbContext.Currencies.Add(entity);
             return _dbContext.SaveChangesAsync();
        }

        return  Task.CompletedTask;
    }

    public Task<Currency> FindByCodeAsync(int code)
    {
       throw new NotImplementedException();
    }

    public Task<Currency> FindByCurrencyCodeAsync(string currencycode)
    {
        throw new NotImplementedException();
    }

    public Task UpsertCurrenciesAsync(IEnumerable<Currency> currencies)
    {

        foreach (var entity in currencies)
        {
            _dbContext.Currencies.Add(entity);
        }
        
        return _dbContext.SaveChangesAsync();
    }

    public Task<DateTime> TimeUpdatedAsync()
    {
        return _dbContext.Currencies
            .OrderByDescending(c => c.RateUpdateDate)
            .Select(c => c.RateUpdateDate)
            .FirstOrDefaultAsync();
    }
}