using System;
using System.Collections.Generic;

using MvcEFTest.Autofac.Demo.Model;


namespace MvcEFTest.Autofac.Demo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IList<User> users = new List<User>();

        public IList<User> GetAll()
        {
            //new List<User>(){
            //    new User{UserId=new Guid(),UserName="admin",Password="123456"},
            //    new User{UserId=new Guid(),UserName="guojiaming",Password="123456"},
            //    new User{UserId=new Guid(),UserName="tianshizhilei",Password="123456"},
            //    new User{UserId=new Guid(),UserName="narato",Password="123456"}
            //};
            return users;
        }

        public void Insert(User user)
        {

        }

        public void Update(int id)
        { }

        public int Delete(int id)
        {
            return 0;
        }
    }
}