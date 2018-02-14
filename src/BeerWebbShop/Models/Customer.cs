using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeerWebbShop.Models
{
    public class Customer
    {

        //[StringLength(20, ErrorMessage = "Name must be shorter than 20 character")]
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set;}

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }



}
