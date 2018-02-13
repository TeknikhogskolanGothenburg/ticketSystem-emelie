using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerWebbShop.Models
{
    public class Product
    {
   
        public int Id { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(20,ErrorMessage = "Product name must be shorter than 20 character")]
        public string ProductName { get; set; }

      
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

    }
}
