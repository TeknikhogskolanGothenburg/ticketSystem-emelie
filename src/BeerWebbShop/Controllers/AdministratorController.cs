using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeerWebbShop.Models;
using BeerWebbShop.Services;

namespace BeerWebbShop.Controllers
{
    public class AdministratorController : Controller
    {
        RestService restService = new RestService();

        public IActionResult SearchOrder()
        {

            return View();
        }

        public IActionResult AddProduct(Product product)
        {
            if(!string.IsNullOrEmpty(product.ProductName))
            {
                try
                {
                    var result = restService.AddProduct(product).Result;
                    if (product != null)
                    {
                        return View(result);
                    }
                }
                catch (Exception e)
                {

                    ViewBag.Error = e.Message;
                }
               
            }
     
            return View();
        }


        public IActionResult ChangePassword()
        {
            return View();
        }


        public IActionResult CreateUser(User user)
        {
            var result = restService.CreateUser(user).Result;

            if (user != null)
            {
                return View(result);
            }
            return View();
            
        }         
                


        public IActionResult UserPage(string UserName, string PassWord)
        {

            return View();
        }


        public IActionResult DeleteProduct(string productName)
        {

            return View();
        }

    }

}

