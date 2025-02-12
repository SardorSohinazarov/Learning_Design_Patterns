INotifier notifier = new EmailNotifier(); // Asosiy notifier
notifier = new SMSNotifier(notifier);     // SMS qo‘shildi
notifier = new FacebookNotifier(notifier); // Facebook qo‘shildi
notifier = new TelegramNotifier(notifier); // Telegram qo‘shildi

notifier.Send("Hello, world!");

//Email sent: Hello, world!
//SMS sent: Hello, world!
//Facebook message sent: Hello, world!
//Telegram message sent: Hello, world!


public interface INotifier
{
    void Send(string message);
}

public class NotifierDecorator : INotifier
{
    protected INotifier _notifier;

    public NotifierDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Send(string message)
    {
        _notifier.Send(message);
    }
}

public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class SMSNotifier : NotifierDecorator
{
    public SMSNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SMS sent: {message}");
    }
}

public class FacebookNotifier : NotifierDecorator
{
    public FacebookNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Facebook message sent: {message}");
    }
}

public class TelegramNotifier : NotifierDecorator
{
    public TelegramNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Telegram message sent: {message}");
    }
}


