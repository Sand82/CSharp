namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var libraryService = new OutsideLibrary();
            var proxyLibrary = new CachedLibrary(libraryService);

            var libraryManager = new BookManager(proxyLibrary);
            libraryManager.SetAllFunctionalities();
        }       
    }
}