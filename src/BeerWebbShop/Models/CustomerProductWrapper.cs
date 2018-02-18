using BeerWebbShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerWebbShop.Models
{
    public class CustomerProductWrapper
    {
        public Customer customer { get; set; }
        public List<Product> products { get; set; }
        
    }
}
