using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Students.Students.Manage
{
    public class ManageStudentController :StudentsBaseController
    {
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteStudent(int studentId)
        {
            var command = new DeleteStudent(studentId);
            await Mediator.Send(command);

            return NoContent();
        }
    }
}
