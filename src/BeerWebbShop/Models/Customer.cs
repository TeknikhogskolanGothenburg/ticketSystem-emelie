using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerWebbShop.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }


        [Display(Name = "Firstname")]
        public string FirstName { get; set; }

        
        [Display (Name = "Lastname")]
        public string LastName { get; set; }

     
        public string Address { get; set;}

    
        [Display(Name = "Zipcode")]
        public int ZipCode { get; set; }

   
        public string City { get; set; }

 
        public string Country { get; set; }


        [EmailAddress]
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }



}
