using System;
using Microsoft.AspNetCore.Mvc;
using BeerWebbShop.Models;
using BeerWebbShop.Services;
using System.Net;

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


        public IActionResult ValidateUser(User user)

        {
            var result = restService.GetByUsernameAndPassword(user);
          
            if (result.Result.StatusCode == HttpStatusCode.OK)
            {
                return View("UserPage");
            }

            ViewBag.Message = TempData["ErrorMessage"] = "Wrong Username or Password, Please try again!";
            return RedirectToAction("Login", "Home");

        }

        public IActionResult ChangePassword()
        {
            return View();
        }


        public IActionResult CreateUser(User user)
        {
            var result = restService.CreateUser(user).Result;

            if (result != null)
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

