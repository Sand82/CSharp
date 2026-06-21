using System;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton singletonOne = Singleton.Instance;

            Singleton singletonOTwo = Singleton.Instance;

            Singleton singletonThree = Singleton.Instance;         
        }
    }
}
