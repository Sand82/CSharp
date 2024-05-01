namespace Proxy
{
    public class BookManager
    {
        protected ILibrary service;

        public BookManager(ILibrary outsideLibrary)
        {
            this.service = outsideLibrary;
        }
        public void CheckAllBooks()
        {
            var books = service.GetAllBooks();

            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public void WriteBook(int id)
        {
            var book = service.GetBook(id);

            Console.WriteLine(book.ToString());
        }

        public void CheckBorrowedBook(int id)
        {            
            var book = service.BorrowBook(id);

            Console.WriteLine(book.ToString());
        }

        public void SetAllFunctionalities()
        {
            CheckAllBooks();
            Console.WriteLine("-------------------------------");
            WriteBook(1);
            Console.WriteLine("-------------------------------");
            CheckBorrowedBook(3);
        }
    }
}
