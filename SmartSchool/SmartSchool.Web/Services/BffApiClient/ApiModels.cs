namespace SmartSchool.Web.Services.BffApiClient;

public record StudentCreate(string RollNumber , string FirstName, string LastName, DateTime DateOfBirth);

public record StudentBasicInfo(int Id, string RollNumber, string FirstName, string LastName, DateTime DateOfBirth, int Age);


