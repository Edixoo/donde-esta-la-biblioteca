using DataAccessLayer.Repository;
using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace BusinessLayer.Test
{
    [TestClass]
    public class BusinessLayerTest
    {
        [TestMethod]
        public void GetFantasyBooks_Test()
        {
            var mockRepository = new Mock<IRepository<Book>>();
            var books = new List<Book> { new Book { Id = 1, Title = "Le Horla", Type = Book.BookType.Fantasy }, new Book { Id = 2, Title = "La parure", Type = Book.BookType.Action, Rate = 5 } };
            mockRepository.Setup(m => m.GetAll()).Returns(books);
            var catalogManager = new CatalogManager(mockRepository.Object);
            var listBooks = catalogManager.GetFantasyBooks();
            Assert.IsNotNull(listBooks);
            Assert.AreEqual(1, listBooks.Count());
        }
        
        
        
        [TestMethod]
        public void FindBooks_Test()
        {
            var mockRepository = new Mock<IRepository<Book>>();
            mockRepository.Setup(m => m.Get(1)).Returns(new Book { Id = 1});
            var catalogManager = new CatalogManager(mockRepository.Object);
            var book = catalogManager.Find(1);
            Assert.IsNotNull(book);
            Assert.AreEqual(1, book.Id);
        }
        
         [TestMethod]
        public void GetBestGradeBook_Test()
        {
            var bookRepository = new Mock<BookRepository>();
            var books = new List<Book> { new Book { Id = 1, Rate = 5 }, new Book { Id = 2, Rate = 3 } };
            bookRepository.Setup(m => m.GetBestGradeBook()).Returns(books[0]);
            var catalogManager = new CatalogManager(bookRepository.Object);
            var topRankedBook = catalogManager.GetBestGradeBook();
            Assert.IsNotNull(topRankedBook);
            Assert.AreEqual(5, topRankedBook.Rate);
            Assert.AreEqual(1, topRankedBook.Id);
        }
        
        
        
    }
}