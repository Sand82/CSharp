using System.Net.Http.Headers;
using System.Threading.Channels;

namespace ObjectInspector;

[AgeAttribute(44)]
public class Person : IPerson, IPrintable
{
    private Guid id = Guid.NewGuid();
    private int age = 20;
    public Person()
    {
        
    }

    public Person(string? firstName, string? lastName)
    {
        FirstName = firstName;
        LastName = lastName;        
    }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age 
    {
        get { return age; }
        set => Console.WriteLine(value); 
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public void Print()
    {
        Console.WriteLine(GetFullName());
    }

    private void WorkingCompany(string company)
    {
        Console.WriteLine($"Person working company {company}");
    }
}
