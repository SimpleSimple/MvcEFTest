using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEFTest.Models
{
    public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            var users = new List<User>() { 
                new User{UserName="郭明霞", Password="123456", CreateTime=DateTime.Now, IsEnable=1},
                new User{UserName="张无忌", Password="123456", CreateTime=DateTime.Now, IsEnable=1},
                new User{UserName="深千骨", Password="123456", CreateTime=DateTime.Now, IsEnable=1},
                new User{UserName="赵敏", Password="123456", CreateTime=DateTime.Now, IsEnable=1},
                new User{UserName="周芷若", Password="123456", CreateTime=DateTime.Now, IsEnable=1},
                new User{UserName="小龙女", Password="123456", CreateTime=DateTime.Now, IsEnable=1},
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();


            //base.Seed(context);
        }
    }
}