using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreFilter.Models;
using Microsoft.AspNetCore.Http;
using AspCoreFilter.Extensions;

namespace AspCoreFilter.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            HttpContext.Session.Set<User>("login-user", user);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Set<User>("login-user", null);
            return RedirectToAction("Index", "Home");
        }
    }
}
