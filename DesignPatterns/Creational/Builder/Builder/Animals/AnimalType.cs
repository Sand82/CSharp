namespace Builder.Animals
{
    public abstract class AnimalType
    {
        protected Animal animal;

        public Animal? Animal 
        { 
            get { return animal; }
        }

        public abstract void DescribeName();

        public abstract void DescribeBody();

        public abstract void CountLegs();

        public abstract void HasWings();
    }
}
