namespace Prototype;

public class Report : IPrototype
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Report(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public IPrototype Clone()
    {
        return (IPrototype)this.MemberwiseClone();
    }

    public void Show()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine("-------------------------");
    }
}
