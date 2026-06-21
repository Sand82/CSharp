using System.Collections;

namespace Iterator;

public class Company : IEnumerable<Employee>
{
    private readonly List<Employee> employees = new();    

    public void Add(Employee employee)
    {
        employees.Add(employee);
    }

    public IEnumerable<Employee> Developers()
    {
        foreach (var employee in employees)
        {
            if (employee.Department?.ToLower() == "development")
            {
                yield return employee;
            }
        }
    }

    public IEnumerable<Employee> Managers()
    {
        foreach(var employee in employees)
        {
            if (employee.Department?.ToLower() == "management")
            {
                yield return employee;
            }
        }
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        foreach (var employee in employees)
        {
            yield return employee;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
