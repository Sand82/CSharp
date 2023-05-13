using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        bool Delete(int id);
        PersonModel? FindById(int id);
        List<PersonModel> GetAll();
        PersonModel Insert(string firstName, string lastName);
    }
}