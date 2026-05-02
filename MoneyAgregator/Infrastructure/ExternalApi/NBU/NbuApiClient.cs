namespace MoneyAgregator.Infrastructure.ExternalApi.NBU;
using MoneyAgregator.Infrastructure.ExternalApi.NBU;

public class NbuApiClient
{
    readonly HttpClient _httpClient;
    
    public NbuApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<NbuCurrencyDto>> GetCurrencyAsync()
    {
        var responce = await _httpClient.GetFromJsonAsync<List<NbuCurrencyDto>>
        (
            "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json"
        );
        return responce ?? new List<NbuCurrencyDto>();
    }
    
}