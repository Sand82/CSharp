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

        [Get("/students/{studentId}")]
        Task<StudentDetails> GetStudentDetails(int studentId);
    }
}

public record CreateStudent(string RollNumber, string FirstName, string LastName, string Email, DateTime DateOfBirth);

public record StudentBaseInfo(int StudentId, string RollNumber, string FirstName, string LastName, string Email, DateTime DateOfBirth, int Age);

public record PagingOptions(int PageNumber = 1, int PageSize = 10);

public record StudentDetails(int StudentId, string FirstName, string LastName, string? Email, DateTime DateOfBirth, string? PhoneNumber, 

       AddressDetails? Address, ICollection<StudentRelative> Relatives);

public record AddressDetails(string Street, int StreetNumber, string City, string State, string PostalCode, string Country);

public record StudentRelative(bool isGuardian, string FirstName, string LastName, RelativeType RelationshipToStudent);

public enum RelativeType
{
    Mother,
    Father,
    Brother,
    Sister
}