namespace NotificationService;

public class Notification
{
    public string Message { get; set; }
    public NotificationType Type { get; set; }
    public List<long> Users { get; set; }

    public Notification(string message, NotificationType type, List<long> users)
    {
        Message = message;
        Type = type;
        Users = users;
    }
}

public enum NotificationType
{
    Firebase,
    Email,
    Sms,
    TelegramBot
}
