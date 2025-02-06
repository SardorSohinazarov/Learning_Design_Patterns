namespace NotificationService.Services;

public class EmailNotificationService : INotificationService
{
    public void Send(Notification notification)
        => Console.WriteLine($"Sending Email notification to {notification.Users.Count()} users with message: {notification.Message}");
}
