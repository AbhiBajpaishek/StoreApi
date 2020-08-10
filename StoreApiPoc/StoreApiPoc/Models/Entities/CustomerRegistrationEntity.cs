using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApiPoc.Models.Entities
{
    public class CustomerRegistrationEntity
    {
        public string Email { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}