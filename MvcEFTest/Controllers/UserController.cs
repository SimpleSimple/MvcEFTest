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

        public ActionResult Delete()
        {
            return View();
        }

    }
}
