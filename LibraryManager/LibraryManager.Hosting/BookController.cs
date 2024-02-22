using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Services;

namespace LibraryManager.Hosting;


[Route("api/[controller]")]
[ApiController]
public class BookController: ControllerBase
{
    private readonly ICatalogService _service;

    public BookController(ICatalogService catalogService)
    {
        _service = catalogService;
    }
    
    // GET: api/book
    [HttpGet]
    public IEnumerable<Book> GetBooks()
    {
        return _service.ShowCatalog().ToList();
    }

    // GET: api/book/{id}
    [HttpGet("{id:int}")]
    public Book GetBooksById(int id)
    {
        var book = _service.FindBook(id);

        return book;
    }
    
    // GET: api/book/{type}
    [HttpGet("{type}")]
    public IEnumerable<Book> GetBooksById(Book.BookType type)
    {
        var books = _service.GetFantasyBooks();

        return books.ToList();
    }
    
    // GET: api/book/topRated
    [HttpGet]
    [Route("topRated")]
    public Book GetTopRated()
    {
        var books = _service.GetBestGradeBook();

        return books;
    }
}