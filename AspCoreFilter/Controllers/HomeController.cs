using Microsoft.AspNetCore.Mvc;
using AspCoreFilter.Extensions;
using AspCoreFilter.Models;
using AspCoreFilter.Filters;

namespace AspCoreFilter.Controllers
{
    [UserFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = HttpContext.Session.Get<User>("login-user");
            return View(user);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
