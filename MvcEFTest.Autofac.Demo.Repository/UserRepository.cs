using System;

using MvcEFTest.Autofac.Demo.Model;


namespace MvcEFTest.Autofac.Demo.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User[] GetAll()
        {
            return new User[] { 
                new User{UserId=new Guid(),UserName="admin",Password="123456"},
                new User{UserId=new Guid(),UserName="guojiaming",Password="123456"},
                new User{UserId=new Guid(),UserName="tianshizhilei",Password="123456"},
                new User{UserId=new Guid(),UserName="narato",Password="123456"}            
            };
        }
    }
}