namespace MoneyAgregator.Core.Entity;

public class UserEntity
{
    public Guid Id { get; private set; }
    public string UserName { get; private set; }
    public CurrencyEntity[] Balance { get; private set; }  
    public DateTime BalanceLastUpdated { get; private set; }
  
    
    
    
    public UserEntity(string userName)
    {
        Id = Guid.NewGuid();
        UserName = userName;
        BalanceLastUpdated = DateTime.UtcNow;


    }

    
    void UpdateUsername (string userName)
    {
        UserName = userName;
       
    }
    
}