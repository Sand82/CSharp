using Refit;

namespace SmartSchool.Bff.ApiClients
{
    public interface IStudentsApiClient
    {
        [Post("/students")]
        Task<StudentBaseInfo> CreateStudent([Body] CreateStudent newStudent);
    }
}

public record CreateStudent(string RollNumber, string FirstName, string LastName, DateTime DateOfBirth);
public record StudentBaseInfo(int Id, string RoleNumber, string FirstName, string LastName, string Email ,DateTime DateOfBirth, int Age);
