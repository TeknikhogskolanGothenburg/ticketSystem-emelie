using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerWebbShop.Models
{
    [System.Runtime.Serialization.DataContract]
    public class Product
    {
        [System.Runtime.Serialization.DataMember]
        public int Id { get; set; }

        [Display (Name = "Product name")]
        [System.Runtime.Serialization.DataMember]
        public string ProductName { get; set; }

        [System.Runtime.Serialization.DataMember]
        public string Description { get; set; }

        [System.Runtime.Serialization.DataMember]
        public int Price { get; set; }

        [System.Runtime.Serialization.DataMember]
        public string ImageName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }


        public string ImageUrl
        {
            get
            {
                return "/images/Product/" + ImageName;
            }

        }


    }
}
