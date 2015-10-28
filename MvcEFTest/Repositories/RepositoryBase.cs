using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MvcEFTest.Models;
using System.Data.Entity;

namespace MvcEFTest.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //private readonly DbSet<TEntity> _dbSet;
        private DbContext _context;
        protected DbContext Context { get { return this._context; } }

        public RepositoryBase(DbContext context)
        {
            this._context = context;
        }

        public virtual int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChanges();
        }
    }
}