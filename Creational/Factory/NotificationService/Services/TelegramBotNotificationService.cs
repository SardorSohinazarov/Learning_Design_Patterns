namespace NotificationService.Services;

public class TelegramBotNotificationService : INotificationService
{
    public void Send(Notification notification) 
        => Console.WriteLine($"Sending Telegram notification to {notification.Users.Count()} with message: {notification.Message}");
}
