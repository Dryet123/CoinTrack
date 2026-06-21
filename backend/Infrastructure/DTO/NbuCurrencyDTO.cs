using System.Text.Json.Serialization;

namespace MoneyAgregator.Infrastructure.DTO;

public class NbuCurrencyDto
{
    [JsonPropertyName("r030")]
    public int Code { get; }
    [JsonPropertyName("сс")]
    public string CurrencyCode { get;}
    [JsonPropertyName("rate")]
    public decimal Rate { get;}
    [JsonPropertyName("exchangedate")]
    public DateTime RateUpdateDate { get;}
}