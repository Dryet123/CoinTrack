namespace MoneyAgregator.Core.Entity;

public class User
{
    public Guid Id { get; private set; }
    public string UserName { get; private set; }
    public Currency[] Balance { get; private set; }  
    public DateTime BalanceLastUpdated { get; private set; }
  
    
    
    
    public User(string userName)
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