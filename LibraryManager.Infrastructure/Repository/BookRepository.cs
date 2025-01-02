using LibraryManager.Infrastructure.Entities;
using LibraryManager.Infrastructure.Interface;

namespace LibraryManager.Infrastructure.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context) { }
    }
}
