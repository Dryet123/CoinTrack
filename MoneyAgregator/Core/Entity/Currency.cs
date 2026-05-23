namespace MoneyAgregator.Core.Entity;

public class Currency
{
    public Guid Id { get; set; }
    
    public int  Code { get;  set; }
    public string CurrencyCode { get; set; }
    public decimal Rate { get;  set; }
    public DateTime RateUpdateDate { get; set; }
    
    void UpdateRate(decimal newRate)
    {
        Rate = newRate;
        RateUpdateDate = DateTime.UtcNow;
    }
    
}