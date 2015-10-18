using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEFTest.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll(Func<T, bool> exp);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}