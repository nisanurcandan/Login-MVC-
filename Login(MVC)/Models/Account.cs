using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Login_MVC_.Models
{
    public class Account
    {
        //[DisplayName("Name")]
        public string Name { get; set; }

        public string Password { get; set; }
    }
}