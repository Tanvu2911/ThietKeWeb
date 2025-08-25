using Microsoft.AspNetCore.Mvc;

namespace Day02Lab.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            
            return View();
        }
    }
}
