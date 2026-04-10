using MoneyAgregator.Core.Entity;
namespace MoneyAgregator.Aplication;

public interface ICurrencyRepository : IRepository<Currency>
{
    Task<Currency> FindByCodeAsync(Guid id);
    
}