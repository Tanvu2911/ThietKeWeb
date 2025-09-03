using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab03.ViewComponents
{
    public class NewProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var newProducts = new List<Product>
            {
                new Product{Id=10, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=1200000},
                new Product{Id=11, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=8500000},
                new Product{Id=12, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/Noicom.jpg", Price=8500000}
            };
            return View(newProducts);
        }
    }
}