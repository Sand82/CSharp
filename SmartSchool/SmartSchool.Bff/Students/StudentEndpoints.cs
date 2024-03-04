using Microsoft.AspNetCore.Mvc;
using SmartSchool.Bff.ApiClients;
using System.Runtime.InteropServices;

namespace SmartSchool.Bff.Students
{
    public static class StudentEndpoints
    {
        public static async IEndpointRouteBuilder AddStudentEndpoints(this IEndpointRouteBuilder app)
        {
            var students = app.MapGroup("/students");            

            students.MapPost("/create", async ([FromBody]CreateStudent newStudent, 
                [FromServices] IStudentsApiClient studentClient) 
                => await CreateStudent(studentClient, newStudent));

            return app;
        }

        private static async Task<IResult> CreateStudent(IStudentsApiClient studentsClient, CreateStudent newStudent)
        {
            var result = await studentsClient.CreateStudent(newStudent);
            return TypedResults.Ok(result);
        }
    }
}
