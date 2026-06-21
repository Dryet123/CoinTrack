using MoneyAgregator.Core.Entity;

namespace MoneyAgregator.Core.Interfaces;

public interface ICurrencyRepository : IRepository<Currency>
{
    Task<Currency> FindByCodeAsync(int code);
    
    Task<Currency> FindByCurrencyCodeAsync(string currencyCode);
    
    Task UpsertCurrenciesAsync(IEnumerable<Currency> currencies);
    
    Task<DateTime> TimeUpdatedAsync();
    
}