using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInspector
{
    [Serializable]
    public class Employee
    {
        public Employee(string? firstName, string? lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public bool IsSingle { get; set; } = false;
        public double Salary { get; set; } = 25000.50;
    }
}
