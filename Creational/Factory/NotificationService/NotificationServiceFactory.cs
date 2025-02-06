using NotificationService.Services;

namespace NotificationService;

public class NotificationServiceFactory
{
    public static INotificationService CreateNotificationService(NotificationType type)
    {
        return type switch
        {
            NotificationType.Firebase => new FirebaseNotificationService(),
            NotificationType.Email => new EmailNotificationService(),
            NotificationType.Sms => new SmsNotificationService(),
            NotificationType.TelegramBot => new TelegramBotNotificationService(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}
