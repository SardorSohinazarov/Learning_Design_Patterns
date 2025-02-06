namespace NotificationService.Services;

public class SmsNotificationService : INotificationService
{
    public void Send(Notification notification) 
        => Console.WriteLine($"Sending SMS notification to {notification.Users.Count()} with message: {notification.Message}");
}
