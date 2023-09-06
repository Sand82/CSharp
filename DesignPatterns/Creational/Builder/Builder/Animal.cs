using static Builder.Constants;

namespace Builder
{
    public class Animal
    {

        private string animalType;

        private Dictionary<string, string> characteristics = new Dictionary<string, string>();

        public Animal(string animalType)
        {
            this.animalType = animalType;
        }

        public string this[string name]
        {
            get { return characteristics[name]; }
            set { characteristics[name] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Animal: {0}", animalType);
            Console.WriteLine(" Name : {0}", characteristics[Name]);
            Console.WriteLine(" - Body : {0}", characteristics[Body]);
            Console.WriteLine(" - Wings: {0}", characteristics[Wings]);
            Console.WriteLine(" - Legs : {0}", characteristics[Legs]);
        }
    }
}
