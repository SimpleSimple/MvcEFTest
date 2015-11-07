using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;

using Autofac;
using Autofac.Integration.Mvc;
using MvcEFTest.Autofac.Demo.Repositories;


namespace MvcEFTest.Autofac.Demo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //容器注册管理
            ContainerManagment();

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        /// <summary>
        /// 容器注册管理
        /// </summary>
        static void ContainerManagment()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterTypes(Assembly.Load("MvcEFTest.Autofac.Demo.Repositories").GetTypes()).AsImplementedInterfaces();

            // Change controller action parameter injection by changing web.config.
            builder.RegisterType<ExtensibleActionInvoker>().As<IActionInvoker>().InstancePerRequest();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}