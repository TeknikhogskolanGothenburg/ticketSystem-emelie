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
        MailService mailService = new MailService();

        public static List<Product> cartList = new List<Product>();
        public static List<Product> beerList = new List<Product>();
        
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

            return View(new CustomerProductWrapper { products = cartList });
        }

        public IActionResult Login()
        {

            return View();
        }

        public  IActionResult ConfirmOrder(Customer customer)
        {
            var order = new Order();
            var oldCustomer = restService.CheckIfCustomerExist(customer);

            if(oldCustomer != null)
            {

                order.Products = cartList;
                order.OrderDate = DateTime.Now;
                order.CustomerId = oldCustomer.Id;
               
               // skicka mail.
            }
            else
            {
                var newCustomer = restService.CreateCustomer(customer);

                order.Products = cartList;
                order.OrderDate = DateTime.Now;
                order.CustomerId = newCustomer.Id;
            }
            
            var orderResult = restService.CreateOrder(order);

            //skapa ett nytt order obejct lägg på produkterna 
            //Skicka mail till kunden i fråga.

            //retunera nått trevligt till användaren att prokdukterna kommer snart, och att de får ett mail på sin order


            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
