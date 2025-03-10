using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T? Get(int id);

        Task<T?> Add(T? element);
    }
}