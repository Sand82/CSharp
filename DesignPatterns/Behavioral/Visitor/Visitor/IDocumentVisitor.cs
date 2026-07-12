namespace Visitor;

public interface IDocumentVisitor
{
    public void Visit(Paragraph paragraph);
    public void Visit(Image image);
    public void Visit(Table table);
}
