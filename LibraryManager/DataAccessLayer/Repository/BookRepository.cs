using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IRepository<AEntity>
    {
        public IEnumerable<AEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public AEntity? Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}