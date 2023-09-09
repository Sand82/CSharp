namespace Proxy
{
    public class Operations : IOperation
    {
        public int AddThreeValues(int one, int two, int three)
        {
            return one + two + three;
        }

        public int AddTwoValues(int one, int two)
        {
            return two + one;
        }

        public int SubstractThreeValues(int one, int two, int three)
        {
            return one - two - three; 
        }

        public int SubstractTwoValues(int one, int two)
        {
            return one - two;
        }
    }
}
