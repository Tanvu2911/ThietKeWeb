using System.Diagnostics;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product{Id=1, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=8500000},
            new Product{Id=2, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=8500000},
            new Product{Id=3, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=8500000}
        };

        // Hi?n th? t?t c? s?n ph?m
        public IActionResult Index()
        {
            return View(products);
        }

        // Partial View: hi?n th? menu danh m?c
        public IActionResult CategoryMenu()
        {
            var categories = new List<string> { "Áo dài", "Áo ðông", "Túi xách", "Ð?ng h?", "Ví da", "Thát lýng da", "T? l?nh", "Tivi", "Qu?t ði?n", "L? sý?i" };
            return PartialView("_CategoryMenu", categories);
        }
    }
}
