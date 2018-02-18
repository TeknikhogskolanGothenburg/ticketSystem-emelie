using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RestApi.Model
{

    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        
    }
}
