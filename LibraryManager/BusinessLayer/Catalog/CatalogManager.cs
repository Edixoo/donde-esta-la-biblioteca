using System;
using System.Linq;
using BusinessObjects.Entity;
using DataAccessLayer.Repository;

namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private readonly BookRepository _bookRepository = new BookRepository();
        
        public IEnumerable<Book> DisplayCatalog()
        {
            return _bookRepository.GetAll();
        }

        public Book Find(int id)
        {
            return _bookRepository.Get(id);
        }

        public  IEnumerable<Book> GetFantasyBooks()
        {
            IEnumerable<Book> books = _bookRepository.GetAll();

            var fantasyBooks = books.Where(book => book.Type == Book.BookType.Fantasy);

            foreach (var book in fantasyBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Author}");
            }

            return fantasyBooks;
        }

        public Book GetBestGradeBook()
        {
            IEnumerable<Book> books = _bookRepository.GetAll();

            var bestBook = books.OrderByDescending(book => book.Rate).FirstOrDefault();

            if (bestBook != null)
            {
                Console.WriteLine($" {bestBook.Title}  {bestBook.Rate}");
            }
            else
            {
                Console.WriteLine("Aucun livre trouve.");
            }

            return bestBook;
        }
    }
}