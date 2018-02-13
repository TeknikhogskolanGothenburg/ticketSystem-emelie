using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerWebbShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
