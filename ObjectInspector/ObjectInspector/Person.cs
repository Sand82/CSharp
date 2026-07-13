namespace ObjectInspector;

[Serializable]
public class Person
{
    private Guid id = Guid.NewGuid();
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
    public int Age { get; set; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public void Print()
    {
        Console.WriteLine(GetFullName());
    }
}
