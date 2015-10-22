using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcEFTest.Models;
using System.Data.Entity;

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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = db.Users.Where(u => u.UserID == id).SingleOrDefault();
            if (user == null)
                return View();

            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(int? id, FormCollection collection)
        {
            if (id == null) throw new ArgumentNullException("id");

            var user = db.Users.Where(u => u.UserID == id).Single();
            if (TryUpdateModel(user))
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(user);
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}
