using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SmartSchool.Web.Data
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions opt) : base(opt)
        {
                
        }
    }
}
