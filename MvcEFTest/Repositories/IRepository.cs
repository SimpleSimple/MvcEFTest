using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        int Add(TEntity entity);
    }
}
