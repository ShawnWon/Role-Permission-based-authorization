using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Claims
{
    public class TestClaimsPrincipalFactory: UserClaimsPrincipalFactory<ApplicationUser>
    {
        public TestClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager, IOptions<IdentityOptions> optionsAccessor) :
            base(userManager, optionsAccessor)
        { }

        public async override Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            var principal = await base.CreateAsync(user);

            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
            new Claim("UserPermissions", user.Permissions.ToString())
            });

            return principal;
        
        }
    }
}
