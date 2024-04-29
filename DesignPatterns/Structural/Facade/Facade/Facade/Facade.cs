using System.Text;

namespace Facade
{
    public class Facade
    {
        private ExternalProviderOne providerOne;

        private ExternalProviderTwo providerTwo;

        private ExternalProviderThree providerThree;

        public Facade(ExternalProviderOne providerOne, ExternalProviderTwo providerTwo, ExternalProviderThree providerThree)
        {
            this.providerOne = providerOne;
            this.providerTwo = providerTwo;
            this.providerThree = providerThree;
        }

        public string Operation()
        {
            var sb = new StringBuilder();

            sb.Append(providerOne.DifficultOperationOne());
            sb.Append(providerTwo.DifficultOperationTwo());
            sb.Append(providerThree.DifficultOperationThree());

            return sb.ToString();
        }
    }
}
