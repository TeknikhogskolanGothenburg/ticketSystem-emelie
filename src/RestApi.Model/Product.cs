using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }

    }
}
