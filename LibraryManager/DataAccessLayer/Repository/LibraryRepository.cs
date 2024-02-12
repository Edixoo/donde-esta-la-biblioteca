using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository : IRepository<Library>
    {
        public IEnumerable<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library? Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}