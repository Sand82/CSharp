using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Students.Data;

namespace SmartSchool.Students.Students.Display
{
    public record ListStudents(PagingOptions Paging) 
        : IRequest<IEnumerable<StudentBasicInfo>>;


    public class ListStudentsHandler : IRequestHandler<ListStudents, IEnumerable<StudentBasicInfo>>
    {
        private readonly AppDbContext _dbContext;

        public ListStudentsHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<StudentBasicInfo>> Handle(ListStudents request, CancellationToken cancellationToken)
        {
            var itemToSkip = request.Paging.PageSize * (request.Paging.PageNumber - 1);
            var students = await _dbContext.Students
                .OrderBy(s => s.Id)
                .Skip(itemToSkip)
                .Take(request.Paging.PageSize)
                .Select(s => new StudentBasicInfo(s.Id, s.RollNumber, s.FirstName, s.LastName, s.Email, s.DateOfBirth, s.Age))
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            return students;

        }
    }
}
