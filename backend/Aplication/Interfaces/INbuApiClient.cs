using MoneyAgregator.Infrastructure.DTO;

namespace MoneyAgregator.Aplication.Interfaces;

public interface INbuApiClient
{
    
    Task<List<NbuCurrencyDto>> GetCurrencyAsync();
    
    
}