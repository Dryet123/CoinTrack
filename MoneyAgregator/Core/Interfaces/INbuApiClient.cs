namespace MoneyAgregator.Core.Interfaces;
using MoneyAgregator.Core.DTO;
public interface INbuApiClient
{
    
    Task<List<NbuCurrencyDto>> GetCurrencyAsync();
    
    
}