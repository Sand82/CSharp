using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Students.Students.Create
{
    public class CreateStudentController : StudentsBaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(StudentBasicInfo),200)]
        public async Task<IActionResult> CreateStudent([FromBody] NewStudent newStudent, CancellationToken token)
        {


            return Ok();
        }
    }    
}

public record NewStudent(string RollNumber, 
    string FirstName, string LastName, DateOnly DateOfBirth);
