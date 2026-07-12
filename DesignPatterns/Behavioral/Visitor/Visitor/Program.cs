using Visitor;

var document = new List<IDocumentElement>
{
    new Paragraph("Hello Visitor Pattern"),
    new Image("photo.jpg"),
    new Table(5)
};

Console.WriteLine("=== PDF Export ===");

IDocumentVisitor pdfVisitor = new PDFExportVisitor();

foreach (var element in document)
{
    element.Accept(pdfVisitor);
}

Console.WriteLine();

Console.WriteLine("=== HTML Export ===");

IDocumentVisitor htmlVisitor = new HTMLExportVisitor();

foreach (var element in document)
{
    element.Accept(htmlVisitor);
}