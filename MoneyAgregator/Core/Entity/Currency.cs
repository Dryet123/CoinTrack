namespace MoneyAgregator.Core.Entity;

public class CurrencyEntity
{
    public Guid Id { get; set; }
    
    public string Code { get;  set; }
    public string CurrencyCode { get; set; }
    public decimal Rate { get; private set; }
    public DateTime RateUpdateDate { get; private set; }
    
    void UpdateRate(decimal newRate)
    {
        Rate = newRate;
        RateUpdateDate = DateTime.UtcNow;
    }
    
}