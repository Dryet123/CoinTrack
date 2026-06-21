namespace MoneyAgregator.Core.Entity;


public enum NotificationType
{
    Email,
    Site
    
}

public enum NotificationStatus
{
    Pending,
    Sent,
    Failed,
}


public class Notification
{
    Guid Id { get; }
    NotificationType Type { get;}
    public NotificationStatus Status { get; private set; }
    public DateTime CreatedDate { get; }
    public string Message { get; }

    Notification(NotificationType type,string message )
    {
        Id = Guid.NewGuid();
        Type = type;
        CreatedDate = DateTime.UtcNow;
        Message = message;
        Status = NotificationStatus.Pending;
    }

    void MarkAsSent()
    {
        Status = NotificationStatus.Sent;
    }

    void MarkAsFailed()
    {
        Status = NotificationStatus.Failed;
    }
    
    
    
    
    
}