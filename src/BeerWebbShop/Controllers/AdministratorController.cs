using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeerWebbShop.Models;


namespace BeerWebbShop.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult SearchOrder()
        {

            return View();
        }

        public IActionResult AddProduct()
        {

            return View();
        }


        public IActionResult ChangePassword()
        {

            return View();
        }


        public IActionResult CreateUser()
        {

            return View();
        }


        public IActionResult UserPage(string UserName, string PassWord)
        {

            return View();
        }



        //[HttpPost]
        //[AutoValidateAntiforgeryToken]
        //public IActionResult Create(Product product)
        //{
        //    //Service webshop 
        //    //calculate the best price in shop 
        //    //Add the sheepest beer

        //    //RestService, AddProduckt();

        //    return View();
        //}
    }

}

