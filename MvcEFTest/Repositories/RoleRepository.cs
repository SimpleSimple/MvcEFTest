using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MvcEFTest.Models;
using System.Data.Entity;

namespace MvcEFTest.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRepository<Role>
    {
        public RoleRepository(DbContext context)
            : base(context)
        { }

        public int Add(User user)
        {
            Context.Set<User>().Add(user);
            return Context.SaveChanges();
        }
    }
}