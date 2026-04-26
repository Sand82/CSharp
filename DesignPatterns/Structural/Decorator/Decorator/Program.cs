using Decorator;

INotifier notifier = new BaseNotifier();

notifier = new EmailNotifier(notifier);

notifier.Send("Hello from Email decorator");

notifier = new SMSNotifier(notifier);

notifier.Send("Hello from SMS decorator");