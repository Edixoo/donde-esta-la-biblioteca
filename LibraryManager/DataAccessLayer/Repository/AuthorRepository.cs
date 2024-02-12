using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

using DataAccessLayer.Contexts;
namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IRepository<Author>
    {
        private readonly LibraryContext _context;
        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Author>GetAll()
        {
            return _context.Authors.ToList();
        }
        public Author? Get(int id)
        {
            return _context.Authors.FirstOrDefault(b => b.Id == id);
        }
        
        
    }
}