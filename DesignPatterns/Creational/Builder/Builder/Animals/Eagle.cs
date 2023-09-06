using static Builder.Constants;

namespace Builder.Animals
{
    public class Eagle : AnimalType
    {
        public Eagle()
        {
            animal = new Animal("Eagle");
        }

        public override void CountLegs()
        {
            animal[Legs] = "2";
        }

        public override void DescribeBody()
        {
            animal[Body] = "Feathered";
        }

        public override void DescribeName()
        {
            animal[Name] = "Golden Eagle";
        }

        public override void HasWings()
        {
            animal[Wings] = "2";
        }
    }
}
