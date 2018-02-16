using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeerWebbShop.Models;


namespace BeerWebbShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Beer()
        {
            List<Product> product = new List<Product>();

            for (int i = 10; i < 30; i++)
            {
                product.Add(new Product {ProductName = "Sour Beer" , Price = 32 , Description = "Sour beer with taste of lemon,strawberry and melon", ImageName="beer8.jpg"});
            }
            return View(product);
        }

        public IActionResult Contact()
        {
          

            return View();
        }

        public IActionResult Cart()
        {

            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        public IActionResult ConfirmOrder()
        {

            return View();
        }


  

     
      



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
