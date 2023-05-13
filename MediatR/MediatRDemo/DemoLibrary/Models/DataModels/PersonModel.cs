namespace DemoLibrary.Models.DataModel
{
    public class PersonModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsDelete { get; set; } = false;
    }
}
