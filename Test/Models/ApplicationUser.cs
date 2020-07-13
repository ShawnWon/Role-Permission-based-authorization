using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Permissions { get; set; }

        public ApplicationUser()
        {
            Permissions = "1,2,3";
        }
    }
}
