using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_8.Controllers
{
    using ASP_NET_8.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = GetSampleProducts();

            return View(products);
        }

        private List<Product> GetSampleProducts()
        {
            
            var products = new List<Product>
        {
            new Product { ID = 1, Name = "Product 1", Price = 19.99m, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Product 2", Price = 29.99m, CreatedDate = DateTime.Now.AddDays(-1) },
            new Product { ID = 3, Name = "Product 3", Price = 9.99m, CreatedDate = DateTime.Now.AddDays(-2) },
        };

            return products;
        }
    }

}
