using Builder.Animals;


namespace Builder
{
    public class ZOO
    {
        public void Describe(AnimalType animalType)
        {
            animalType.DescribeName();
            animalType.DescribeBody();
            animalType.HasWings();
            animalType.CountLegs();
        }
    }
}
