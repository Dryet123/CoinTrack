using MoneyAgregator.Infrastructure.DTO;

namespace MoneyAgregator.Core.Interfaces;

public interface INbuApiClient
{
    
    Task<List<NbuCurrencyDto>> GetCurrencyAsync();
    
    
}