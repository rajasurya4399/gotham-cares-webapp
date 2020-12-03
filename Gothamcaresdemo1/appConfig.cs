using System;
using System.Web.Http;

namespace Gothamcaresdemo1.web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // New code
            config.EnableSystemDiagnosticsTracing();


            // Other configuration code not shown.
        }
    }
}
