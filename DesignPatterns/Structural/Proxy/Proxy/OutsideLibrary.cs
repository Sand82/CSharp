namespace Proxy
{
    public class OutsideLibrary : ILibrary
    {   
        private BookCaseDatabase booksDb = new BookCaseDatabase();        

        public List<Book> GetAllBooks()
        {
            return booksDb.books;
        }

        public Book GetBook(int id)
        {
            return FindBook(id);
        }

        public string BorrowBook(int id)
        {
            var book = FindBook(id);

            return $"Borrow {book.Title} with {book.Pages} pages written by {book.Author}";
        }
       
        private Book FindBook(int id)
        {
           return booksDb.books.FirstOrDefault(b => b.Id == id)!;
        }
    }
}
