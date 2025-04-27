using Innovasys_App.Models.Views;

namespace Innovasys_App.Services.UserService
{
    public interface IUserService
    {
        public Task LoadData();

        public List<UserViewModel> GetData();
    }
}
