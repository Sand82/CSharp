using MediatR;
using SmartSchool.Students.Data;
using SmartSchool.Students.Domain.Models;

namespace SmartSchool.Students.Students.Create
{
    public record CreateStudent(NewStudent NewStudent) : IRequest<StudentBasicInfo>;

    public class CreateStudentHandler(AppDbContext contect)
        : IRequestHandler<CreateStudent, StudentBasicInfo>
    {
        public async Task<StudentBasicInfo> Handle(CreateStudent request, CancellationToken cancellationToken)
        {
            var student = Student.Create(
                request.NewStudent.RollNumber, 
                request.NewStudent.FirstName, 
                request.NewStudent.LastName,
                request.NewStudent.DateOfBirth);

            contect.Students.Add(student);
            await contect.SaveChangesAsync(cancellationToken);

            
        }
    }

}
