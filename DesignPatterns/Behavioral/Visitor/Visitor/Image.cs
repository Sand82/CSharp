namespace Visitor;

public class Image : IDocumentElement
{
    public string FileName { get; set; }

    public Image(string fileName)
    {
        FileName = fileName;
    }

    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}
