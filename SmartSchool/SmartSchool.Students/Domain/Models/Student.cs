using System.ComponentModel.DataAnnotations;

namespace SmartSchool.Students.Domain.Models
{
    public class Student
    {
        #region Constructors and properties
        public int Id { get; set; }
            
        public required string RollNumber { get; set; }
        
        public required string FirstName { get; set; }
        
        public required string LastName { get; set; }
        
        public required string Email { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public int Age => CalculateAge();

        public string? PhoneNumber { get; set; }

        public Address? Address { get; set; }
        #endregion

        #region Public behavior
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
