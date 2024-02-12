using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return _context.Books.ToList();
        }
        public Book? Get(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
        }
        public Book? GetBestGradeBook( )
        {
            return _context.Books.OrderByDescending(b => b.Rate).FirstOrDefault();
        }
        
    }
}