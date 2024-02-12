using BusinessLayer.Catalog;
namespace Services.Tests;
using BusinessObjects.Entity;
using Moq;

[TestClass]
public class CatalogService
{
    [TestMethod]
    public void CatalogManager_getFantasyBook()

    {
        var mockManager = new Mock<ICatalogManager> ();
        var books = new List<Book> { new() { Id = 1, Title = "Le Horla", Type = Book.BookType.Fantasy }, new() { Id = 2 , Title = "La parure", Type = Book.BookType.Fantasy, Rate = 5 } };
        mockManager.Setup(m => m.GetFantasyBooks()).Returns(books);
        Assert.IsNotNull(books);
        Assert.AreEqual(2, books.Count);
    }
    
    
    [TestMethod]
    public void TestFindBook()
    {
        var mockRepository = new Mock<ICatalogManager>();
        mockRepository.Setup(m => m.Find(1)).Returns(new Book { Id = 1 });
        var book = mockRepository.Object.Find(1);
        Assert.IsNotNull(book);
        Assert.AreEqual(1, book.Id);
    }
    
    
    [TestMethod]
    public void TestGetBestGradeBook()
    {
        var mockRepository = new Mock<ICatalogManager>();
        var books = new List<Book> { new() { Id = 1, Rate = 5 }, new() { Id = 2, Rate = 3 } };
        mockRepository.Setup(m => m.GetBestGradeBook()).Returns(books[0]);
        Assert.IsNotNull(books[0]);
        Assert.AreEqual(5, books[0].Rate);
        Assert.AreEqual(1, books[0].Id);
    }
}