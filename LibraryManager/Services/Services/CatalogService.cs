using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Repository;


namespace Services.Services;

public class CatalogService : ICatalogService

{
    private ICatalogManager _catalogManager;

    public CatalogService(ICatalogManager catalogManager)
    {
        _catalogManager = catalogManager;
    }
    public IEnumerable<Book> ShowCatalog()
    {
        return _catalogManager.DisplayCatalog();
    }

    public Book FindBook(int id)
    {
        return _catalogManager.Find(id);
    }
    public IEnumerable<Book> GetFantasyBooks()
    {
        return _catalogManager.GetFantasyBooks();

    }
    public Book GetBestGradeBook()
    {
        return _catalogManager.GetBestGradeBook();

    }
}


