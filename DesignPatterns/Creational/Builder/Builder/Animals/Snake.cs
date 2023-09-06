using static Builder.Constants;

namespace Builder.Animals
{
    public class Snake : AnimalType
    {
        public Snake()
        {
            animal = new Animal("Snake");
        }

        public override void CountLegs()
        {
            animal[Legs] = "0";
        }

        public override void DescribeBody()
        {
            animal[Body] = "Long body";
        }

        public override void DescribeName()
        {
            animal[Name] = "Cobra";
        }

        public override void HasWings()
        {
            animal[Wings] = "0";
        }
    }
}
