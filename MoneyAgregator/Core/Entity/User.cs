namespace MoneyAgregator.Core.Entity;

public class User
{
    public Guid Id { get;  set; }
    
    public string? UserName { get;  set; }
    
    public string? Email { get;  set; }
    
    public DateTime BalanceLastUpdated { get;  set; }
    
    public string? PasswordHash { get;  set; }
    
    public DateTime CreatedAt { get;  set; }
    
    public ICollection<DemoAccount> DemoAccounts = new List<DemoAccount>();

}