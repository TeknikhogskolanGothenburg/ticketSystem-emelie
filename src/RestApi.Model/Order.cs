using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace RestApi.Model
{
    public class Order
    {
   
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        //public ICollection<Product> Products { get; set; }


    }
}
