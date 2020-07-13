using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Authorization
{
    public class TestRequirement:IAuthorizationRequirement
    {
        public List<int> permIdList { get; set; }
        public TestRequirement(List<int> permissions)
        {
            permIdList = permissions;  
        }
    }
}
