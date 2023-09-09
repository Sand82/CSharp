namespace Proxy
{
    public class OperationsProxy : IOperation
    {
        private Operations operations = new Operations();

        public int AddThreeValues(int one, int two, int three)
        {
            return operations.AddThreeValues(one, two, three);
        }

        public int AddTwoValues(int one, int two)
        {
            return operations.AddTwoValues(one, two);
        }

        public int SubstractThreeValues(int one, int two, int three)
        {
            return operations.SubstractThreeValues(one, two, three);
        }

        public int SubstractTwoValues(int one, int two)
        {
            return operations.SubstractTwoValues(one, two);
        }
    }
}
