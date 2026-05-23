namespace MoneyAgregator.Core.Entity;

public class DemoAccount
{
    Guid Id { get; }
    
    string Code { get; }
    
    decimal Balance { get; }


    private ICollection<DemoTransaction> Transactions = new List<DemoTransaction>();
}