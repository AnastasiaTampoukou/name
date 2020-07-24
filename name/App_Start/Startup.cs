using Owin;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Web;

namespace name.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var cp = ConfigProfile.LoadConfigurationProfile();
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            /*app.UseIdentityServerBearerTokenAuthedication(new UseIdentityServerBearerTokenAuthedicationOptions 
            {
                Authority = $@"https://{cp.AuthorityServerHost}/{cp.AuthorityResourceName}",
                Clientid = cp.ClientId,
                ClientSecret = cp.ClientSecret,
                RequieredScopes = new[] { cp.RequiredScope }
            });
            app.UseOAuthBearerAuthentication(new Microsoft.Owin.Security.OAuth.OAuthBearerAuthenticationOptions
            {
                Authority = $@"https://{cp.AuthorityServerHost}/{cp.AuthorityResourceName}",
                Clientid = cp.ClientId,
                ClientSecret = cp.ClientSecret,
                RequieredScopes = new[] { cp.RequiredScope}
            });*/
        }
    }
}