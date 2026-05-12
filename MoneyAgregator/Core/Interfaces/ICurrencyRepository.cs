using MoneyAgregator.Core.Entity;

namespace MoneyAgregator.Core.Interfaces;

public interface ICurrencyRepository : IRepository<CurrencyEntity>
{
    Task<CurrencyEntity> FindByCodeAsync(string code);
    
    Task<CurrencyEntity> FindByCurrencyCodeAsync(string currencyCode);
    
    Task UpsertCurrenciesAsync(IEnumerable<CurrencyEntity> currencies);
    
    Task<DateTime> TimeUpdatedAsync();
    
}