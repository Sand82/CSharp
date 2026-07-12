namespace Visitor;

public class HTMLExportVisitor : IDocumentVisitor
{
    public void Visit(Paragraph paragraph)
    {
        Console.WriteLine($"<p> { paragraph.Text} </p>");
    }

    public void Visit(Image image)
    {
        Console.WriteLine($"<image src=\\{image.FileName}\\ />");
    }

    public void Visit(Table table)
    {
        Console.WriteLine($"<table><!-- {table.Rows} rows --></table>");
    }
}
