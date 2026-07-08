namespace State;

public class PublishedState : IDocumentState
{
    public void Publish(Document document)
    {
        Console.WriteLine("Document is already published.");
    }
}
