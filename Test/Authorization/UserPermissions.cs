using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Authorization
{
    public class UserPermissions : IUserPermissions
    {
        public List<int> Get(string permList)
        {
            return permList.Split(',').Select(x=>Int32.Parse(x)).ToList();
        }
    }
}
