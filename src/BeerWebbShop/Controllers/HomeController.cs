using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeerWebbShop.Models;
using BeerWebbShop.Services;

namespace BeerWebbShop.Controllers
{
    public class HomeController : Controller
    {
        RestService restService = new RestService();
        public static List<Product> cartList = new List<Product>();
        public static List<Product> beerList = new List<Product>();
        public static List<Product> confirmedBeer = new List<Product>();

        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult Beer(Product product)
        {
            if(product != null)
            {
                cartList.Add(product);
            }

            if(beerList.Count <= 0)
            {
                beerList = restService.GetAllProducts().Result;
            }

            if (beerList != null)
            {
                return View(beerList);
            }
            return View();
            
        }

        
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Cart()
        {

            return View(cartList);
        }

        public IActionResult Login()
        {

            return View();
        }

        public IActionResult ConfirmOrder(List<Product> productsConfirmed)
        {
            if(productsConfirmed != null)
            {
                confirmedBeer = productsConfirmed;
            }
            
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
