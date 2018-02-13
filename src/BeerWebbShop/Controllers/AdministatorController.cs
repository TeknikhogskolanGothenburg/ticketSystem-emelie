using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeerWebbShop.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeerWebbShop.Controllers
{
    public class AdministatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Product product)
        {
            //Service webshop 
            //calculate the best price in shop 
            //Add the sheepest beer

            //RestService, AddProduckt();

            return View();
        }
    }

}

