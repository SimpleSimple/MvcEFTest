using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcEFTest.Repositories;

namespace MvcEFTest.Controllers
{
    public class RoleController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

    }
}
