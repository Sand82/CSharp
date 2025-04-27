using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

using Innovasys_App.Models.DTOs;
using Innovasys_App.Models.Views;
using Innovasys_App.Data;
using Innovasys_App.Data.Models;

namespace Innovasys_App.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly ApiService apiService;
        private readonly AppDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly IDbConnection dbConnection;

        public UserService(
            ApiService apiService, 
            AppDbContext dbContext, 
            IConfiguration configuration, 
            IDbConnection dbConnection)
        {
            this.apiService = apiService;
            this.dbContext = dbContext;
            this.configuration = configuration;
            this.dbConnection = dbConnection;
        }

        public async Task LoadData()
        {
            if (!this.dbContext.Users.Any())
            {
                var data = await apiService.LoadData();

                await AddDataToDB(data);
            }
        }

        public List<UserViewModel> GetData()
        {
            var sql = @"
                 SELECT 
                 u.Id, u.Name, u.NotUsername, u.Email, u.Phone, u.Website, u.Note, u.IsActive, u.CreatedAt,
                 a.Id AS AddressId, a.Street, a.Suite, a.City, a.ZipCode, a.Lat, a.Lng, a.UserId
                 FROM Users u
                 LEFT JOIN Addresses a ON a.UserId = u.Id";

            var userDictionary = new Dictionary<int, UserViewModel>();

            var users = dbConnection.Query<UserViewModel, AddressViewModel, UserViewModel>(
                sql,
                (user, address) =>
                {
                    if (!userDictionary.TryGetValue(user.Id, out var userEntry))
                    {
                        userEntry = user;
                        userDictionary.Add(userEntry.Id, userEntry);
                    }

                    userEntry.Address = address;
                    return userEntry;
                },
                splitOn: "AddressId"
            ).Distinct().ToList();

            return users;
        }

        private async Task AddDataToDB(List<UserDTO> data)
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
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true,
                };

                using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
                {
                    await connection.OpenAsync();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {                            
                            var insertUserQuery = @"
                                INSERT INTO Users (Name, NotUsername, Phone, Email, Website, CreatedAt, IsActive)
                                VALUES (@Name, @NotUsername, @Phone, @Email, @Website, @CreatedAt, @IsActive);
                                SELECT CAST(SCOPE_IDENTITY() as int);
                            ";

                            var userId = await connection.ExecuteScalarAsync<int>(insertUserQuery, currUser, transaction);

                           
                            var insertAddressQuery = @"
                                INSERT INTO Addresses (Street, Suite, City, ZipCode, Lat, Lng, UserId)
                                VALUES (@Street, @Suite, @City, @ZipCode, @Lat, @Lng, @UserId);
                            ";

                            var currAddress = new
                            {
                                Street = user.Address.Street,
                                Suite = user.Address.Suite,
                                City = user.Address.City,
                                ZipCode = user.Address.ZipCode,
                                Lat = double.Parse(user.Address.Geo.Lat),
                                Lng = double.Parse(user.Address.Geo.Lng),
                                UserId = userId
                            };

                            await connection.ExecuteAsync(insertAddressQuery, currAddress, transaction);
                            
                            await transaction.CommitAsync();
                        }
                        catch
                        {
                            await transaction.RollbackAsync();
                            throw;
                        }
                    }
                }
            }
        }        
    }
}
