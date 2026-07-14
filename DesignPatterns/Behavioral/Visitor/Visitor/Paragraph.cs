namespace Visitor;

public class Paragraph : IDocumentElement
{   
    public string? Text { get; set; }

    public Paragraph(string? text)
    {
        Text = text;
    }
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}
