using Builder;
using Builder.Animals;
using Builder.VehiclesBuilders;
using System;

namespace Bulder
{
    public class Program
    {
        public static void Main(string[] args)
        {           
            AnimalType animalType;
            
            ZOO zoo = new ZOO();

            animalType = new Dog();
            zoo.Describe(animalType);
            animalType.Animal.Show();

            animalType = new Snake();
            zoo.Describe(animalType);
            animalType.Animal.Show();

            animalType = new Eagle();
            zoo.Describe(animalType);
            animalType.Animal.Show();
        }
    }
}