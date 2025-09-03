using System.Diagnostics;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product{Id=1, Name="N?i c�m �i?n cao t?n Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=8500000},
            new Product{Id=2, Name="N?i c�m �i?n cao t?n Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=8500000},
            new Product{Id=3, Name="N?i c�m �i?n cao t?n Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=8500000}
        };

        // Hi?n th? t?t c? s?n ph?m
        public IActionResult Index()
        {
            return View(products);
        }

        // Partial View: hi?n th? menu danh m?c
        public IActionResult CategoryMenu()
        {
            var categories = new List<string> { "�o d�i", "�o ��ng", "T�i x�ch", "�?ng h?", "V� da", "Th�t l�ng da", "T? l?nh", "Tivi", "Qu?t �i?n", "L? s�?i" };
            return PartialView("_CategoryMenu", categories);
        }
    }
}
