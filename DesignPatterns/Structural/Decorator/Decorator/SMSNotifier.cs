namespace Decorator;

public class SMSNotifier : NotifierDecorator
{
    public SMSNotifier(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
    }

    private void SendSMS(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
