using Refit;

namespace SmartSchool.Bff.ApiClients
{
    public interface IStudentsApiClient
    {
        [Post("/students")]
        Task<StudentBaseInfo> CreateStudent([Body] CreateStudent newStudent);

        [Get("/students")]
        Task<StudentBaseInfo[]> ListStudents([Query] PagingOptions paging);

        [Delete("/students/{studentId}")]
        Task DeleteStudent(int studentId);
    }
}

public record CreateStudent(string RollNumber, string FirstName, string LastName, string Email, DateTime DateOfBirth);
public record StudentBaseInfo(int StudentId, string RollNumber, string FirstName, string LastName, string Email, DateTime DateOfBirth, int Age);
public record PagingOptions(int PageNumber = 1, int PageSize = 10);
