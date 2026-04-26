namespace Decorator;

public class BaseNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Base notification: " + message);
    }
}
