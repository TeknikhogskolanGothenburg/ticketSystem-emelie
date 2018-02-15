using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string ImageUrl { get; set; }
    }
}
