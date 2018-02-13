using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerWebbShop.Models
{
    public class Customer
    {
    
        public int Id { get; set; }

       
        //[StringLength(20, ErrorMessage = "Name must be shorter than 20 character")]
        public string FirstName { get; set; }

     
        public string LastName { get; set; }

        public string Address { get; set;}

     
        public int ZipCode { get; set; }

     
        public string City { get; set; }

 
        public string Country { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }



}
