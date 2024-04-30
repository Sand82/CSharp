namespace Composite
{
    public class LeafOne : INumber
    {
        private int one = 1;

        public int GetNumber()
        {
            return one;
        }
    }
}
