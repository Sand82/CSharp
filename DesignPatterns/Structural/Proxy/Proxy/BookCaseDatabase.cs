namespace Proxy
{
    public class BookCaseDatabase
    {
        public List<Book> books = new List<Book>()
        {            
           new Book (1, "Things Fall Apart", 209, "Chinua Achebe"),
           new Book(2, "Fairy tales", 784, "Hans Christian Andersen"),         
           new Book(3, "Pride and Prejudice", 228, "Jane Austen"),        
           new Book(4, "The Divine Comedy", 928, "Dante Alighieri"),        
           new Book(5, "Molloy, Malone Dies, The Unnamable, the trilogy", 256, "Samuel Beckett")        
        };        
    }
}
