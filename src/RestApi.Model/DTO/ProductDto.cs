using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Model.DTO
{
    public class ProductDto
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
