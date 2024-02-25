using BusinessObjects.Entity;
using DataAccessLayer.Contexts;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IRepository<Book>
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context) 
        {
            _context = context;

        }
        public IEnumerable<Book> GetAll()
        {
            if (_context.Books != null) return _context.Books.ToList();
            throw new Exception();
        }
        public Book? Get(int id)
        {
            if (_context.Books != null) return _context.Books.FirstOrDefault(b => b.Id == id);
            throw new Exception();
        }
        public Book? GetBestGradeBook( )
        {
            if (_context.Books != null) return _context.Books.OrderByDescending(b => b.Rate).FirstOrDefault();
            throw new Exception();
        }
        
        public IEnumerable<Book> GetFantasyBooks()
        {
            if (_context.Books != null) return _context.Books.Where(b => b.Type == Book.BookType.Fantasy).ToList();

            throw new Exception();
        }

        public async Task<Book?> Add(Book? book)
        {
            var createdBook = await _context.Books.AddAsync(book);

            _context.SaveChangesAsync();

            return Get(book.Id);
        }
    }
}
