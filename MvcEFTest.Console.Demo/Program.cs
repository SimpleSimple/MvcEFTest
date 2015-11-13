using System;

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

            ////反射
            //var types = Assembly.Load("MvcEFTest.Autofac.Demo.Repositories").GetTypes();
            //foreach (var obj in types)
            //{
            //    System.Console.WriteLine(obj.FullName);
            //}

            System.Console.Write("1)工厂示例\r\n2)反射示例\r\n3)序列化对象示例\r\n请输入:");
            int i = Convert.ToInt32(System.Console.ReadLine());
            switch (i)
            {
                case 3:
                    ExecuteMethod3();
                    break;
                default: break;
            }
        }

        private static void ExecuteMethod3()
        {
            var user = new { UserId = 1, UserName = "duoqingjianke", Password = "123456" };
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            System.Console.WriteLine(json);
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
