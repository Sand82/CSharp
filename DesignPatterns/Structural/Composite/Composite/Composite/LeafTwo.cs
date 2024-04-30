namespace Composite
{
    public class LeafTwo : INumber
    {
        private int Two = 2;

        public int GetNumber()
        {
            return Two;
        }
    }
}
