using MoneyAgregator.Core.Entity;
namespace MoneyAgregator.Aplication;

public interface ICurrencyRepository : IRepository<CurrencyEntity>
{
    Task<CurrencyEntity> FindByCodeAsync(Guid id);
    
}