using BusinessObjects.Entity;
namespace Services.Services
{
    public interface ICatalogService
    {
        public IEnumerable<Book> ShowCatalog();
        public Book FindBook(int id);

        public IEnumerable<Book> GetFantasyBooks();

        public Book FindBook();
        
        public Book GetBestGradeBook();

        public Task<Book?> AddBook(Book book);
    }
}