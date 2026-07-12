using static System.Net.Mime.MediaTypeNames;

namespace Visitor;

public class PDFExportVisitor : IDocumentVisitor
{
    public void Visit(Paragraph paragraph)
    {
        Console.WriteLine("PDF: Paragraph " + paragraph.Text);
    }

    public void Visit(Image image)
    {
        Console.WriteLine("PDF: Image " + image.FileName);
    }

    public void Visit(Table table)
    {
        Console.WriteLine("PDF: table " + table.Rows);
    }
}
