namespace Proxy
{
    public interface ILibrary
    {
        public List<Book> GetAllBooks();

        public Book GetBook(int id);

        public string BorrowBook(int id);    
    }
}
