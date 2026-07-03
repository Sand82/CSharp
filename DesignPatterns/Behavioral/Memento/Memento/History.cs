namespace Memento;

public class History
{
    private readonly Stack<TextEditorMemento> history = new();

    public void Save(TextEditorMemento memento)
    {
        history.Push(memento);
    }

    public TextEditorMemento Undo()
    {
        if (history.Count <= 0)
        {
            return null;
        }

        return history.Pop();
    }
}
