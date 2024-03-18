using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Students.Data;

namespace SmartSchool.Students.Students.Display
{
    public record GetStudentDetails(int StudentId) : IRequest<StudentDetails>;

    public class GetStudentDetailsHandler(AppDbContext context) : IRequestHandler<GetStudentDetails, StudentDetails>
    {
        public async Task<StudentDetails> Handle(GetStudentDetails request, CancellationToken cancellationToken)
        {
            var student = await context.Students
                .Include(x => x.Address)
                .Include(x => x.Relatives)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == request.StudentId, cancellationToken);

            return StudentDetails.FromStudent(student);
        }
    }
}
