using LibraryManager.Application.Interface;
using LibraryManager.Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManager.Pages;

public class IndexModel : PageModel
{
    private readonly IBookService _bookService;

    public IndexModel(IBookService bookService)
    {
        _bookService = bookService;
    }

    public IList<Book> Books { get; set; } = new List<Book>();

    public async Task OnGetAsync()
    {
        Books = (await _bookService.GetAllBooksAsync()).ToList();
    }
}
