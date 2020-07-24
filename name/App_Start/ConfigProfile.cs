using bUtility.WebApi;
//using Microsoft.Owin.Logging;
//using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace name.App_Start
{
    public class ConfigProfile : ConfigurationProxy
    {
        public static ConfigProfile Current { get; set; }
        public readonly Func<IDbConnection> AuditDBConnection;

        public readonly string AuthorityServerHost = LoadString("authorityServerHost");
        public readonly string AuthorityResourceName = LoadString("authorityResourceName");
        public readonly string ClientId = LoadString("apiResourceName");
        public readonly string ClientSecret = LoadString("apiResourceValue");
        public readonly string RequiredScope = LoadString("apiScopeName");

        internal static ConfigProfile LoadConfigurationProfile()
        {
            Current = new ConfigProfile();
            return Current;
        }
        //static readonly ILogger Logger = new bUtility.Logging.Logger("ibankApiSource");
    }
}