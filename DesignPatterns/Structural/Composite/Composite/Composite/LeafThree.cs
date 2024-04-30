namespace Composite
{
    public class LeafThree : INumber
    {
        private int three = 3;

        public int GetNumber()
        {
            return three;
        }
    }
}
