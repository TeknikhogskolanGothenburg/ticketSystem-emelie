﻿using System;
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
           
            return View();
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

        public IActionResult UserPage()
        {

            return View();
        }


        public IActionResult CreateUser()
        {

            return View();
        }

        public IActionResult ChangePassword()
        {

            return View();
        }





        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}