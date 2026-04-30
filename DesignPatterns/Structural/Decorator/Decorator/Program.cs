using Decorator;

var baseNotifier = new BaseNotifier();

while (true)
{
    Console.WriteLine("------ New Message ------");

    Console.WriteLine("Send message via SMS or Email");

    var notifierType = Console.ReadLine()!;

    INotifier notifier;

    if (notifierType.ToLower() == "email")
    {
        notifier = new EmailNotifier(baseNotifier);
    }
    else if (notifierType.ToLower() == "sms")
    {
        notifier = new SMSNotifier(baseNotifier);
    }
    else
    {
        break;
    }

    Console.WriteLine("What should be the message?");

    var messageToSend = Console.ReadLine()!;

    notifier.Send(messageToSend);
}