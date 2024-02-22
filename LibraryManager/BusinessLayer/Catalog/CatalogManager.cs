using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects.Entity;
using DataAccessLayer.Repository;

namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private readonly IRepository<Book> _bookRepository;

        public CatalogManager(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> DisplayCatalog()
        {
            return _bookRepository.GetAll();
        }

        public Book Find(int id)
        {
            return _bookRepository.Get(id);
        }

        public IEnumerable<Book> GetFantasyBooks()
        {
            return _bookRepository.GetAll().Where(book => book.Type == Book.BookType.Fantasy);
        }

        public Book GetBestGradeBook()
        {
            var bestBook = (from book in _bookRepository.GetAll()
                orderby book.Rate descending
                select book).FirstOrDefault();

            if (bestBook != null)
            {
                Console.WriteLine($"{bestBook.Name} - {bestBook.Rate}");
            }
            else
            {
                Console.WriteLine("Aucun livre trouvé.");
            }

            return bestBook;
        }
    }
}