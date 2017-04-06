using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Clearsettle.Reporting.Web.App_Start;

namespace Clearsettle.Reporting.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}