using Adapter;

var oldPrinter = new OldPrinter();

var printer = new AdapterPrinter(oldPrinter);

printer.PrintText("Hello Adapter Pattern in .NET!");