namespace SmartSchool.Web.Services.BffApiClient;

public record StudentCreate(string RollNumber , string FirstName, string LastName, string Email, DateTime DateOfBirth);

public record StudentBasicInfo(int StudentId, string RollNumber, string FirstName, string LastName, string Email, DateTime DateOfBirth, int Age);


