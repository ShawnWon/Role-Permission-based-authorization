using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Test.Authorization
{
    public class TestHandler : AuthorizationHandler<TestRequirement>
    {
        private readonly IUserPermissions userpermissions;
        public TestHandler(IUserPermissions userperms)
        {
            this.userpermissions = userperms;
        }

        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context, 
            TestRequirement requirement)
        {
            var claim = ((ClaimsIdentity)context.User.Identity).FindFirst("UserPermissions");

            if (claim == null)
            {
                return Task.CompletedTask;
            }

            var permlist = context.User.FindFirst("UserPermissions");
            var perms = userpermissions.Get(permlist.Value);

            if (requirement.permIdList.All(x => perms.Contains(x)))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
