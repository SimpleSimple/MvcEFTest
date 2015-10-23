using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEFTest.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsEnable
        {
            get;
            set;
        }
    }
}