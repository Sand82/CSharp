namespace Adapter;

public class AdapterPrinter : IPrinter
{
    private readonly OldPrinter oldPrinter;

    public AdapterPrinter(OldPrinter oldPrinter)
    {
        this.oldPrinter = oldPrinter;
    }
    public void PrintText(string text)
    {
        oldPrinter.PrintText(text);
    }
}
