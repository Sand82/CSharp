using Refit;

namespace SmartSchool.Web.Services.BffApiClient
{
    public interface IBffApiClient
    {
        [Post("/students")]
        Task<StudentBasicInfo> CreateStudentAsync([Body] StudentCreate newStudent);

        [Get("/students")]
        Task<StudentBasicInfo[]> ListStudentsAsync([Query] PagingOptions paging);

        [Delete("/students/{studentId}")]
        Task DeleteStudentAsync(int studentId);
    }

    public record PagingOptions(int PageNumber = 1, int PageSize = 10);
}
