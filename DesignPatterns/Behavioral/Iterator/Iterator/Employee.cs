namespace Iterator;

public class Employee
{
    public Employee(string? name, string? department)
    {
        Name = name;
        Department = department;
    }

    public string? Name { get; set; }
    public string? Department { get; set; }
}
