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

        public ActionResult Index(string Search)
        {
            var users = from u in db.Users
                        select u;

            if (!string.IsNullOrEmpty(Search))
            {
                users = users.Where(u => u.UserName.Contains(Search));
            }

            return View(users.ToList());
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
        public ActionResult Edit([Bind(Include = "UserID, UserName, IsEnable, CreateTime")]User model, FormCollection collection = null)
        {
            if (ModelState.IsValid)
            {

                db.Entry(model).State = EntityState.Modified;
                int result = db.SaveChanges();

                if (result > 0)
                    return RedirectToAction("index");
                else return View(model);
            }

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (user == null) throw new ArgumentNullException("user");

            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(user);
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}
