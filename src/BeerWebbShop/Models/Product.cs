using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerWebbShop.Models
{
    public class Product
    {
        public string ProductName { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string ImageName;

        public string ImageUrl
        {
            get
            {
                return "/images/Product/" + ImageName;
            }

        }

       
    }
}
