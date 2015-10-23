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
                new User{UserName="郭明霞", Password="123456", CreateTime=DateTime.Parse("2015-09-01"), IsEnable=true},
                new User{UserName="张无忌", Password="123456", CreateTime=DateTime.Parse("2014-09-01"), IsEnable=false},
                new User{UserName="深千骨", Password="123456", CreateTime=DateTime.Parse("2013-09-01"), IsEnable=true},
                new User{UserName="赵敏", Password="123456", CreateTime=DateTime.Parse("2012-09-01"), IsEnable=false},
                new User{UserName="周芷若", Password="123456", CreateTime=DateTime.Parse("2011-09-01"), IsEnable=true},
                new User{UserName="小龙女", Password="123456", CreateTime=DateTime.Parse("2010-09-01"), IsEnable=false},
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();


            //base.Seed(context);
        }
    }
}