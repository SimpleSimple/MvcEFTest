using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    public interface IUserRepository
    {
        void Insert();

        void Update();

        void GetAll();
    }
}
