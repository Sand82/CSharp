using Iterator;

var company = new Company()
{
    new Employee("John", "Development"),
    new Employee("Alice", "Management"),
    new Employee("Bob", "Development"),
    new Employee("Sarah", "HR"),
    new Employee("Sand", "Management"),
    new Employee("Misho", "Development"),
    new Employee("Lubo", "Support"),
    new Employee("Maria", "Support")
};

Console.WriteLine("All Employees");

foreach (var employee in company)
{
    Console.WriteLine($"{employee.Name} - {employee.Department}");
}

Console.WriteLine(new string('-', 20));

Console.WriteLine("All Managers");

foreach (var employee in company.Managers())
{
    Console.WriteLine($"{employee.Name} - {employee.Department}");
}

Console.WriteLine(new string('-', 20));

Console.WriteLine("All Developers");

foreach (var employee in company.Developers())
{
    Console.WriteLine($"{employee.Name} - {employee.Department}");
}