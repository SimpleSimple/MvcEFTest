using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MvcEFTest.Interfaces;
using MvcEFTest.Models;

namespace MvcEFTest.Impl
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public EFDbContext context;

        public Repository(EFDbContext context)
        {
            this.context = context;
        }

        public IQueryable<T> GetAll(Func<T, bool> exp)
        {
            return this.context.Set<T>().AsQueryable<T>();
        }

        public void Add(T entity)
        {
            //this.context.Entry<T>().
        }

        public void Update(T entity)
        { }

        public void Delete(T entity)
        { }
    }
}