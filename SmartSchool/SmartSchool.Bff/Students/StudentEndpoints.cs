using Microsoft.AspNetCore.Mvc;
using SmartSchool.Bff.ApiClients;

namespace SmartSchool.Bff.Students
{
    public static class StudentEndpoints
    {
        public static IEndpointRouteBuilder AddStudentEndpoints(this IEndpointRouteBuilder app)
        {
            var students = app.MapGroup("/students");            

            students.MapPost("/", async ([FromBody]CreateStudent newStudent, 
                [FromServices] IStudentsApiClient studentClient) 
                => await CreateStudent(studentClient, newStudent))
                .WithName("CreateStudent")
                .Produces(200, typeof(StudentBaseInfo));

            return app;
        }

        private static async Task<IResult> CreateStudent(IStudentsApiClient studentsClient, CreateStudent newStudent)
        {
            var result = await studentsClient.CreateStudent(newStudent);
            return TypedResults.Ok(result);
        }
    }
}
