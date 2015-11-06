using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    public class UserRespository : IUserRepository
    {
        public void Insert()
        {
            System.Console.WriteLine("Insert Operate!");
        }

        public void Update()
        {
            System.Console.WriteLine("Update Operate!");
        }

        public void GetAll()
        {
            System.Console.WriteLine("GetAll Operate!");
        }
    }
}
