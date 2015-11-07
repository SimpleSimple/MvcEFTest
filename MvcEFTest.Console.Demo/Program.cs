using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using Autofac;

namespace MvcEFTest.Console.Demo
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            //NYStylePizzaStore nyStore = new NYStylePizzaStore();
            //var pizza = nyStore.OrderPizza("veggie");

            //Autofac注入
            //var builder = new ContainerBuilder();
            //builder.RegisterType<UserRespository>().As<IUserRepository>();
            ////builder.RegisterType<TodayWrite>().As<IDateWrite>();
            //Container = builder.Build();

            //GetAll();

            var types = Assembly.Load("MvcEFTest.Autofac.Demo.Repositories").GetTypes();
            foreach (var obj in types)
            {
                System.Console.WriteLine(obj.FullName);
            }
        }

        public static void GetAll()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<IUserRepository>();
                repository.GetAll();
            }
        }
    }
}
