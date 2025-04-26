using Innovasys_App.Data;
using Innovasys_App.Data.Models;
using Innovasys_App.Models;
using System.Text.Json;

namespace Innovasys_App.Services.UserService
{
    public class UserService : IUserService
    {
        private ApiService apiService;
        private AppDbContext dbContext;

        public UserService(ApiService apiService, AppDbContext dbContext)
        {
            this.apiService = apiService;
            this.dbContext = dbContext;
        }

        public async Task GetData()
        {
            if (!this.dbContext.Users.Any())
            {
                var data = await apiService.LoadData();

                await AddDateToDB(data);
            }
        }  
        
        private async Task AddDateToDB(List<UserDTO> data)
        {
            foreach (var user in data)
            {
                var currUser = new User
                {
                    Name = user.Name,
                    NotUsername = user.Username,
                    Phone = user.Phone,
                    Email = user.Email,
                    Website = user.Website,
                    CreatedAt = DateTime.Now,
                    IsActive = true,
                };

                var currAddress = new Address
                {
                    Street = user.Address.Street,
                    Suite = user.Address.Suite,
                    City = user.Address.City,
                    ZipCode = user.Address.ZipCode,
                    Lat = double.Parse(user.Address.Geo.Lat),
                    Lng = double.Parse(user.Address.Geo.Lng),
                    User = currUser
                };

                await this.dbContext.Users.AddAsync(currUser);
                await this.dbContext.Addresses.AddAsync(currAddress);
            }

            await this.dbContext.SaveChangesAsync();
        }
    }
}
