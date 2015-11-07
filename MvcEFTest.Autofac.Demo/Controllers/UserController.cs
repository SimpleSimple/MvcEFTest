using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcEFTest.Autofac.Demo.Repositories;

namespace MvcEFTest.Autofac.Demo.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public ActionResult Index()
        {
            var users = _userRepository.GetAll();
            return View(users);
        }

    }
}
