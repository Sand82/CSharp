namespace TemplateMethod;

public abstract class ReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("Start report generation...");
        LoadData();
        ProcessData();
        ExportData();

        Console.WriteLine("Report generation complete.");
    }

    protected abstract void LoadData();
    protected abstract void ProcessData();

    protected virtual void ExportData()
    {
        Console.WriteLine("Export data in PDF format.");
    }
}
