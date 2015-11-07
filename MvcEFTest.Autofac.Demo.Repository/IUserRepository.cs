using System;

using MvcEFTest.Autofac.Demo.Model;


namespace MvcEFTest.Autofac.Demo.Repositories
{
    public interface IUserRepository
    {
        User[] GetAll();
    }
}