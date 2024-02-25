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
            return _context.author.ToList();
        }
        public Author? Get(int id)
        {
            return _context.author.FirstOrDefault(b => b.Id == id);
        }

        public async Task<Author?> Add(Author? author)
        {
            var createdAuthor = await _context.author.AddAsync(author);

            _context.SaveChangesAsync();

            return Get(author.Id);
        }
    }
}