using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;

namespace HRMS
{
    public class OAuthProvider : OAuthAuthorizationServerProvider
    {
        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            return Task.Factory.StartNew(() =>
            {
                var email = context.UserName;
                var password = context.Password;
                var user = DbContext.User.Login(email, password);
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Sid, user.UserId.ToString()),
                        new Claim(ClaimTypes.Email, user.Email)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, Startup.OAuthOptions.AuthenticationType);

                    var data = new Dictionary<string, string>();
                    data.Add("userId", user.UserId.ToString());
                    data.Add("email", user.Email);
                    data.Add("firstName", user.FirstName);
                    data.Add("lastName", user.LastName);
                    data.Add("fullName", user.FullName);
                    data.Add("nickName", user.NickName);
                    data.Add("roleId", user.RoleId.ToString());
                    data.Add("roleName", user.RoleName);
                    data.Add("compId", user.CompId.ToString());
                    data.Add("branchId", user.BranchId.ToString());
                    data.Add("empId", user.EmpId.ToString());

                    var properties = new AuthenticationProperties(data);

                    var ticket = new AuthenticationTicket(claimsIdentity, properties);
                    context.Validated(ticket);
                }
                else
                {
                    context.SetError("invalid_grant", "invalid credentials");
                }
            });
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            if (context.ClientId == null)
                context.Validated();

            return Task.FromResult<object>(null);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (var property in context.Properties.Dictionary)
                context.AdditionalResponseParameters.Add(property.Key, property.Value);

            return Task.FromResult<object>(null);
        }
    }
}