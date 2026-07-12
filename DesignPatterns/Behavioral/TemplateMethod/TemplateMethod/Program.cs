using TemplateMethod;

ReportGenerator sales = new SalesReportGenerator();
sales.GenerateReport();

Console.WriteLine();

ReportGenerator inventory = new InventoryReportGenerator();
inventory.GenerateReport();