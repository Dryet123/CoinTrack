using MoneyAgregator.Core.Entity;

namespace MoneyAgregator.Core.Interfaces;

public interface ICurrencyRepository : IRepository<CurrencyEntity>
{
    Task<CurrencyEntity> FindByCodeAsync(Guid id);
    
}