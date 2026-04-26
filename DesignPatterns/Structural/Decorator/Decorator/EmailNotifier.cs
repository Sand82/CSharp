namespace Decorator;

public class EmailNotifier : NotifierDecorator
{
    public EmailNotifier(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        SendEmail(message);
    }

    private void SendEmail(string message)
    {
        Console.WriteLine($"Sending EMAIL: {message}");
    }
}
