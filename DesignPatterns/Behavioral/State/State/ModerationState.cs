namespace State;

public class ModerationState : IDocumentState
{
    public void Publish(Document document)
    {
        Console.WriteLine("Document approved and published.");
        document.State = new PublishedState();
    }
}
