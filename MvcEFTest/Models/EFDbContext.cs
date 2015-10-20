using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MvcEFTest.Models
{
    public partial class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("EFDbContext")
        { }

        public virtual IDbSet<User> Users { get; set; }

    }
}