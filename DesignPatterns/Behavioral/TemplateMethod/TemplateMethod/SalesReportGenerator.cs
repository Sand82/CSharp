namespace TemplateMethod;

public class SalesReportGenerator : ReportGenerator
{
    protected override void LoadData()
    {
        Console.WriteLine("Loading data from SQL server....");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Calculate sales profit.");
    }
}
