using DemoLibrary.Models.DataModel;
using System.Linq;

namespace DemoLibrary.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<PersonModel> peoples = new();

        public DataAccess()
        {
            peoples.AddRange(new[] {
                new PersonModel() { Id = 1, FirstName = "Sand", LastName = "Stef"},
                new PersonModel() { Id = 2, FirstName = "Mish", LastName = "Stef"},
                new PersonModel() { Id = 3, FirstName = "Lub", LastName = "Stef"},
                new PersonModel() { Id = 4, FirstName = "Mim", LastName = "Stef"}
            });
        }

        public List<PersonModel> GetAll()
        {
            var persons = peoples
                .Where(p => p.IsDelete == false)
                .ToList();

            return persons;
        }

        public PersonModel? FindById(int id)
        {
            return peoples
                .FirstOrDefault(x => x.Id == id);
        }

        public PersonModel Insert(string firstName, string lastName)
        {
            var person = new PersonModel();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Id = peoples.Max(p => p.Id) + 1;

            peoples.Add(person);

            return person;
        }

        public PersonModel Edit(string firtName, string lastName, PersonModel editPerson)
        {
            editPerson.FirstName = firtName;
            editPerson.LastName = lastName;

            return editPerson;
        }

        public bool Delete(int id)
        {
            var person = FindById(id);

            if (person == null)
            {
                return false;
            }

            person.IsDelete = true;

            return true;
        }        
    }
}
