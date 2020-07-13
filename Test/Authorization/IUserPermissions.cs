using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Authorization
{
    public interface IUserPermissions
    {
        List<int> Get(string permList);
    }
}
