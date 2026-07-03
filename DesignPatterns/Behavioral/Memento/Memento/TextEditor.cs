namespace Memento;

public class TextEditor
{
    public string? Text { get; private set; } = string.Empty;

    public void Write(string text)
    {
        Text = text;
    }

    public TextEditorMemento Save()
    {
        return new TextEditorMemento(Text);
    }

    public void Restore(TextEditorMemento memento)
    {
        Text = memento.Text;
    }
}
