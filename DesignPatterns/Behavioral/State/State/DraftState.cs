namespace State;

public class DraftState : IDocumentState
{
    public void Publish(Document document)
    {
        Console.WriteLine("Document set for moderation.");
        document.State = new ModerationState();
    }
}
