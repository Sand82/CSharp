using Innovasys_App.Models.Views;
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
            await userService.LoadData();

            var models = userService.GetData();
            
            return View(models);
        }

        [HttpPost]
        public async Task<IActionResult> Add(List<UserViewModel> model)
        {

            await userService.EditData(model);

            return RedirectToAction("Index", "Home");
        }
    }
}
