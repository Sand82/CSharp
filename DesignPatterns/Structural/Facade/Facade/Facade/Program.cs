using System;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            var externalProviderOne = new ExternalProviderOne();
            var externalProviderTwo = new ExternalProviderTwo();
            var externalProviderThree = new ExternalProviderThree();

            var facade = new Facade(externalProviderOne, externalProviderTwo, externalProviderThree);

            Client(facade);
        }

        public static void Client(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}
