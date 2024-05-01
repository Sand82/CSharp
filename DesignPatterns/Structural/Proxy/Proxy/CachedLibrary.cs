namespace Proxy
{
    public class CachedLibrary : ILibrary
    {
        private ILibrary outsideLibrary;

        public CachedLibrary(ILibrary library)
        {
            this.outsideLibrary = library;
        }

        private List<Book>? lastCache;

        private Book? bookCache;

        private bool needReset = false;       

        public List<Book> GetAllBooks()
        {
            if (lastCache == null || needReset)
            {
                lastCache = new List<Book>();
                lastCache = outsideLibrary.GetAllBooks();
            }

            return lastCache;
        }

        public Book GetBook(int id)
        {
            if(bookCache == null || needReset)
            {
                bookCache = outsideLibrary.GetBook(id);
            }

            return bookCache;
        }

        public string BorrowBook(int id)
        {           
            return outsideLibrary.BorrowBook(id);           
        }
    }
}
