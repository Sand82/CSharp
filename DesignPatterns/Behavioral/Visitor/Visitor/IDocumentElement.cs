namespace Visitor;

public interface IDocumentElement
{
    public void Accept(IDocumentVisitor visitor);
}
