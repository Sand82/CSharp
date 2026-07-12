namespace Visitor;

public class Table : IDocumentElement
{
    public int Rows { get; set; }

    public Table(int rows)
    {
        Rows = rows;
    }

    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}
