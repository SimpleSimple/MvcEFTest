using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MvcEFTest.Models
{
    public partial class EFDbContext : DbContext
    {

        public virtual IDbSet<User> User { get; set; }


    }
}