using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using System.Data.Entity;
using MvcEFTest.Models;
using MvcEFTest.Infrastructure;

namespace MvcEFTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Context.Request.FilePath == "/") Context.RewritePath("/Home/Index");
        }

        protected void Application_Start()
        {
            //初始化数据库数据
            Database.SetInitializer<EFDbContext>(new DatabaseInitializer());

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //ViewEngines.Engines.Add(new DebugDataViewEngine());
            ViewEngines.Engines.Insert(0, new DebugDataViewEngine());
        }
    }
}