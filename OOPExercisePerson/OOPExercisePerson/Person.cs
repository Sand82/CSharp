namespace OOPExercisePerson
{
    public class Person
    {
        private const decimal SalaryLinValue = 650;

        private string firstName;

        private string lastName;

        private int age;

        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;

        }

        public string? FirstName 
        {
            get
            {
                return this.firstName;
            }
            
            set 
            {
                if (value.Length < 3) 
                {
                    throw new ArgumentException("First name can't be less than 3 symbols.");
                }

                this.lastName = value;
            }
        }

        public string? LastName 
        { 
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name can't be less than 3 symbols.");
                }

                this.lastName = value;
            }
        }

        public int Age 
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Age can't be negative value.");
                }

                this.age = value;
            }
        }

        public decimal Salary 
        { 
            get
            {
                return this.salary;
            }
            set
            {
                if (value < SalaryLinValue)
                {
                    throw new ArgumentException($"Salary can't be less than {SalaryLinValue} leva.");
                }

                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.age < 30)
            {
                percentage = percentage / 2;
            }

            this.salary += this.salary * percentage / 100;
        }

        public override string ToString()
        {            
            return $"{this.firstName} {this.lastName} is {this.age} years old and receives {this.salary.ToString("f2")} leva.";
        }
    }
}
