namespace MoneyAgregator.Core.Entity;

public class Currency
{
    public Guid Id { get; private  set; }
    public string Code { get; private set; }
    public decimal Rate { get; private set; }
    public DateTime RateUpdateDate { get; private set; }
    
    
    public Currency(string name, decimal rate)
    {
       Guid Id =  Guid.NewGuid();
       name = Code;
       rate = Rate;
       RateUpdateDate = DateTime.UtcNow;
       
    }
    
    void UpdateRate(decimal newRate)
    {
        Rate = newRate;
        RateUpdateDate = DateTime.UtcNow;
    }
    
}