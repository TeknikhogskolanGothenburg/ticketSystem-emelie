using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace RestApi.Model
{
    public class Order
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int CustomerId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
