using static Builder.Constants;

namespace Builder.Animals
{
    public class Dog : AnimalType
    {
        public Dog()
        {
            animal = new Animal("Dog");
        }
        public override void CountLegs()
        {
            animal[Legs] = "4";
        }

        public override void DescribeBody()
        {
            animal[Body] = "Atletic Body";
        }

        public override void DescribeName()
        {
            animal[Name] = "Sharo";
        }

        public override void HasWings()
        {
            animal[Wings] = "no wings";
        }
    }
}
