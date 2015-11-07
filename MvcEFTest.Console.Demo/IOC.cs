using System;

using Autofac;
using Autofac.Builder;

namespace MvcEFTest.Console.Demo
{
    public static class IOC
    {
        private static IContainer _container;

        public static void ContainerRegister()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserRespository>().As<IUserRepository>();

            _container.Resolve<UserRespository>();
            _container = builder.Build();
        }
    }
}
