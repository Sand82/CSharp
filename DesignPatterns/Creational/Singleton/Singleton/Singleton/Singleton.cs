namespace Singleton
{
    public class Singleton
    {
        private static Singleton? instance;
        private static object locker = new object();

        private Singleton() {}

        public static Singleton Instance
        {
            get 
            {
                if (instance == null)
                {
                    lock(locker)
                    {
                        Console.WriteLine("Instance created");
                        instance = new Singleton();
                    }
                }
                return instance;
            }            
        }        
    }   
}
