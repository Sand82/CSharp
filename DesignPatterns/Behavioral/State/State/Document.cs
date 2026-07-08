namespace State;

public class Document
{
    public IDocumentState? State { get; set; }

    public Document()
    {
        State = new DraftState();
    }

    public void Publish()
    {
        State!.Publish(this);
    }
}
