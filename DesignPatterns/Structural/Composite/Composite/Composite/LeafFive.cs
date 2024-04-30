namespace Composite
{
    public class LeafFive : INumber
    {
        private int five = 5;

        public int GetNumber()
        {
            return five;
        }
    }
}
