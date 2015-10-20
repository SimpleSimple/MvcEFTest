using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcEFTest.Models;

namespace MvcEFTest.Controllers
{
    public class UserController : Controller
    {
        private EFDbContext db = new EFDbContext();

        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}
