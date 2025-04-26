using Innovasys_App.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Innovasys_App.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> LoadData()
        {
            await userService.GetData();

            return View();
        }
    }
}
