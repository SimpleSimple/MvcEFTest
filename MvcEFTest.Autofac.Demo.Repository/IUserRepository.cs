using System;
using System.Collections.Generic;

using MvcEFTest.Autofac.Demo.Model;


namespace MvcEFTest.Autofac.Demo.Repositories
{
    public interface IUserRepository
    {
        IList<User> GetAll();

        void Insert(User user);

        void Update(int id);

        int Delete(int id);
    }
}