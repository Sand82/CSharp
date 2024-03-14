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

            students.MapPost("/", async ([FromBody]CreateStudent newStudent, [FromServices] IStudentsApiClient client) 
                                => await CreateStudent(client, newStudent))
                .WithName("CreateStudent")
                .Produces(200, typeof(StudentBaseInfo));

            students.MapGet("/", async(IStudentsApiClient client, int pageNumber, int pageSize)
                                => await ListStudents(client, pageNumber, pageSize))
                .WithName("ListStudents")
                .Produces(200, typeof(StudentBaseInfo[]));

            students.MapDelete("/{studentId}", async ( int studentId,
                                [FromServices] IStudentsApiClient client)
                                => await DeleteStudent(client, studentId))
                .WithName("DeleteStudent")
                .Produces(204);

            return app;
        }

        private static async Task<IResult> DeleteStudent(IStudentsApiClient client, int studentId)
        {
            await client.DeleteStudent(studentId);
            return TypedResults.NoContent();
        }

        private static async Task<IResult> CreateStudent(IStudentsApiClient client, CreateStudent newStudent)
        {
            var result = await client.CreateStudent(newStudent);
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> ListStudents(IStudentsApiClient client, int pageNumber, int pageSize)
        {
            var result = await client.ListStudents(new PagingOptions(pageNumber, pageSize));
            return TypedResults.Ok(result);            
        }
    }
}
