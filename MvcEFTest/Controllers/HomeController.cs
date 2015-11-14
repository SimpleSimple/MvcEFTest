using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcEFTest.Models;

namespace MvcEFTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MakeBooking()
        {
            return View(new Appointment { Date = DateTime.Now });
        }

        [HttpPost]
        public ActionResult MakeBooking(Appointment appt)
        {
            if (String.IsNullOrEmpty(appt.ClientName))
            {
                ModelState.AddModelError("ClientName", "Please enter your name");
            }

            if (ModelState.IsValidField("Date") && DateTime.Now > appt.Date)
            {
                ModelState.AddModelError("Date", "Please enter a date in the future");
            }

            if (!appt.TermsAccepted)
            {
                ModelState.AddModelError("TermsAccepted", "You must accept the terms");
            }

            if (ModelState.IsValidField("ClientName") && ModelState.IsValidField("Date")
                && appt.ClientName == "Joe" && appt.Date.DayOfWeek == DayOfWeek.Monday)
            {
                ModelState.AddModelError("", "Joe cannot book appointment on Mondays"); //添加model-level级的错误提示
            }

            if (ModelState.IsValid)
                return View("Complete", appt);
            else return View();
        }

        public ActionResult QQLogin()
        {
            return View();
        }
    }
}
