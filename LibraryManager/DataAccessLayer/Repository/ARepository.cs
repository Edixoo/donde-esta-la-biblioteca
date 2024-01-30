using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repository
{
    public abstract class ARepository<T> : IRepository<T>
    {
        public IEnumerable<T> GetAll()
        {
            throw new ArgumentOutOfRangeException(
                "Parameter index is out of range.");
        }

        public T? Get(int id)
        {
            throw new ArgumentOutOfRangeException(
                "Parameter index is out of range.");
        }
    }
}