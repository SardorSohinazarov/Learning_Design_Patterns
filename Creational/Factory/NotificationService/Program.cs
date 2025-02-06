namespace NotificationService;

public class Program
{
    public static void Main(string[] args)
    {
        var users = new List<long> { 1, 2, 3, 4, 5 };
        var notification = new Notification("Factory design pattern", NotificationType.Email, users);
        var notificationService = NotificationServiceFactory.CreateNotificationService(notification.Type);
        notificationService.Send(notification);
    }
}
