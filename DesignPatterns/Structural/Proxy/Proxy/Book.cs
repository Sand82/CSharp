namespace Proxy
{
    public class Book
    {
        public Book(int id, string? title, int pages, string? author)
        {
            Id = id;
            Title = title;
            Pages = pages;
            Author = author;
        }

        public int Id { get; set; }

        public string? Title { get; set; }

        public int Pages { get; set; }

        public string? Author { get; set; }

        public override string ToString()
        {
            return $"The Author {this.Author} wrote {this.Pages} pages for {this.Title} book.";
        }
    }
}
