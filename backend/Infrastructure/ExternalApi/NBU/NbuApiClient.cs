using MoneyAgregator.Aplication.Interfaces;
using MoneyAgregator.Infrastructure.DTO;

namespace MoneyAgregator.Infrastructure.ExternalApi.NBU;

using MoneyAgregator.Core.Interfaces;

public class NbuApiClient : INbuApiClient
{
    readonly HttpClient _httpClient;
    readonly ILogger _logger;
    
    public NbuApiClient(HttpClient httpClient, ILogger<NbuApiClient> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<List<NbuCurrencyDto>> GetCurrencyAsync()
    {
        try
        {
            var responce = await _httpClient.GetFromJsonAsync<List<NbuCurrencyDto>>
            (
                "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json"
            );
            return responce ?? new List<NbuCurrencyDto>();
        }
        catch (HttpRequestException e)
        {
            _logger.LogError(e.Message);
            return new List<NbuCurrencyDto>();
        }
            
    }
    
}