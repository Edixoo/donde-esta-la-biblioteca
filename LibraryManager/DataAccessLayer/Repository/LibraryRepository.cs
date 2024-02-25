using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Contexts;


namespace DataAccessLayer.Repository
{
    public class LibraryRepository : IRepository<Library>
    {
        private readonly LibraryContext _context;

        public LibraryRepository(LibraryContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Library> GetAll()
        {
            throw new NotImplementedException();

        }

        public Library? Get(int id)
        {
            throw new NotImplementedException();
            
        }
        
        public Task<Library?> Add(Library? library)
        {
            if (library == null) throw new ArgumentNullException(nameof(library));
            throw new NotImplementedException();
        }
    }
}