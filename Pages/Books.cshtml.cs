using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManager.Pages
{
    public class BooksModel : PageModel
    {
        public List<Book> Books { get; set; } = new List<Book>
    {
        new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951 },
        new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
        new Book { Title = "1984", Author = "George Orwell", Year = 1949 }
    };
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
