using Microsoft.AspNetCore.Mvc;
using SmartSchool.Bff.ApiClients;
using System.Runtime.InteropServices;

namespace SmartSchool.Bff.Students
{
    public static class StudentEndpoints
    {
        public static IEndpointRouteBuilder AddStudentEndpoints(this IEndpointRouteBuilder app)
        {
            var students = app.MapGroup("/students");            

            students.MapPost("/", async ([FromBody]CreateStudent newStudent, [FromServices] IStudentsApiClient studentClient) 
                                => await CreateStudent(studentClient, newStudent))
                .WithName("CreateStudent")
                .Produces(200, typeof(StudentBaseInfo));

            students.MapGet("/", async(IStudentsApiClient client, int pageNumber, int pageSize)
                                => await ListStudents(client, pageNumber, pageSize))
                .WithName("ListStudents")
                .Produces(200, typeof(StudentBaseInfo[]));

            return app;
        }        

        private static async Task<IResult> CreateStudent(IStudentsApiClient studentsClient, CreateStudent newStudent)
        {
            var result = await studentsClient.CreateStudent(newStudent);
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> ListStudents(IStudentsApiClient client, int pageNumber, int pageSize)
        {
            var result = await client.ListStudents(new PagingOptions(pageNumber, pageSize));
            return TypedResults.Ok(result);            
        }
    }
}
