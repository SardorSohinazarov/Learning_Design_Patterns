namespace NotificationService.Services;

public class FirebaseNotificationService : INotificationService
{
    public void Send(Notification notification) 
        => Console.WriteLine($"Sending Firebase notification to {notification.Users.Count()} with message: {notification.Message}");
}
