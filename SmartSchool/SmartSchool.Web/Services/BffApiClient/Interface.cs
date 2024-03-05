using Refit;

namespace SmartSchool.Web.Services.BffApiClient
{
    public interface IBffApiClient
    {
        [Post("/students")]
        Task<StudentBasicInfo> CreateStudentAsync([Body] StudentCreate newStudent);
    }
}
