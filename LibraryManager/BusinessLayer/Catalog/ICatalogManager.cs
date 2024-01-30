namespace BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Repository;


public interface ICatalogManager
{
    public IEnumerable<Book> DisplayCatalog();
    public Book Find(int id);
    public IEnumerable<Book> GetFantasyBooks();
    public Book GetBestGradeBook();
    

}