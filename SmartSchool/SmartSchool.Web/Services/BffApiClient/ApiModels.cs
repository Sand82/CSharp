namespace SmartSchool.Web.Services.BffApiClient;

public record StudentCreate(string RollNumber , string FirstName, string LastName, string Email, DateTime DateOfBirth);

public record StudentBasicInfo(int StudentId, string RollNumber, string FirstName, string LastName, string Email, DateTime DateOfBirth, int Age);

public record StudentDetails(int StudentId, string FirstName, string LastName, string? Email, DateTime DateOfBirth, string? PhoneNumber,

       AddressDetails? Address, ICollection<StudentRelative> Relatives);

public record AddressDetails(string Street, int StreetNumber, string City, string State, string PostalCode, string Country);

public record StudentRelative(bool isGuardian, string FirstName, string LastName, RelativeType RelationshipToStudent);

public enum RelativeType
{
    Mother,
    Father,
    Guardian
}


