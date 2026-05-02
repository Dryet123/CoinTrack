using MoneyAgregator.Core.Entity;

namespace MoneyAgregator.Core.Interfaces;

public interface ICurrencyRepository : IRepository<CurrencyEntity>
{
    Task<CurrencyEntity> FindByCodeAsync(string code);
    Task<CurrencyEntity> FindByCurrencyCodeAsync(string currencycode);
    
    Task UpsertCurrenciesAsync(IEnumerable<CurrencyEntity> currencies);
    
}