using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Autofac.Demo.Model
{
    public class User
    {
        public User() { }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
