namespace TemplateMethod;

public class InventoryReportGenerator : ReportGenerator
{
    protected override void LoadData()
    {
        Console.WriteLine("Loading inventory data from MongoDB...");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Checking stock inventory...");
    }

    protected override void ExportData()
    {
        Console.WriteLine("Export data in Excel document.");
    }
}
