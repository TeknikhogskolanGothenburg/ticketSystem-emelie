using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerWebbShop.Models
{
    public class User
    {
     
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }

      
        [Display(Name = "Lastname")]
        public string LastName { get; set; }

      
        [EmailAddress]
        public string Email { get; set; }

     
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}
