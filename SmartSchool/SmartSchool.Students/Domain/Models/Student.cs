using System.ComponentModel.DataAnnotations;

namespace SmartSchool.Students.Domain.Models
{
    public class Student
    {
        public Student()
        {
            Relatives = new List<Relative>();
        }

        #region Constructors and properties
        public int Id { get; set; }
            
        public required string RollNumber { get; set; }
        
        public required string FirstName { get; set; }
        
        public required string LastName { get; set; }
        
        public string? Email { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public int Age => CalculateAge();

        public string? PhoneNumber { get; set; }

        public Address? Address { get; set; }

        public ICollection<Relative> Relatives { get; set; }
        #endregion

        #region Public behavior
        public static Student Create(string rollNumber, string firstName, string lastName, DateOnly dateOfBirth)
        {
            return new Student
            {
                RollNumber = rollNumber,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth
            };
        }
        #endregion

        #region Private behavior
        private int CalculateAge()
        {
            var currentDate = DateTime.UtcNow;
            var age = currentDate.Year - DateOfBirth.Year;

            if (currentDate.Month < DateOfBirth.Month || 
                currentDate.Month == DateOfBirth.Month && currentDate.Day < DateOfBirth.Day)
            {
                age--;
            }

            return age;
        }
         
        #endregion
    }
}
