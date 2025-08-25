using Microsoft.AspNetCore.Mvc;

namespace Day02Lab.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}
