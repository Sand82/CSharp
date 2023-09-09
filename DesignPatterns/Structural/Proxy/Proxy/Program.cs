namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy =  new OperationsProxy();

            Console.WriteLine($"5 + 5 = {proxy.AddTwoValues(5, 5)}");
            Console.WriteLine($"5 + 5 + 4 = {proxy.AddThreeValues(5, 5, 4)}");
            Console.WriteLine($"10 - 5 = {proxy.SubstractTwoValues(10, 5)}");
            Console.WriteLine($"10 - 5 - 3 = {proxy.SubstractThreeValues(10, 5, 3)}");
        }
    }
}