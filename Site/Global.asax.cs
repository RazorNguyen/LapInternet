using log4net.Config;
using Site.Services;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            XmlConfigurator.Configure();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Logging
            var ex = Server.GetLastError().GetBaseException();
            var httpException = ex as HttpException;
            if (httpException != null)
            {
                return;
            }

            LogService.Error(ex.Message);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Request.UserHostAddress != "::1")
                LogService.Info(Request.UserHostAddress);
        }
    }
}
