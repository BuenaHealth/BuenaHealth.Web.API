using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BuenaHealth.Common.Logging;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Web.API.App_Start;
using BuenaHealth.Web.API.Security;
using BuenaHealth.Web.Common;

namespace BuenaHealth.Web.API
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterHandlers();
            new AutoMapperConfigurator().Configure(WebContainerManager.GetAll<IAutoMapperTypeConfigurator>());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterHandlers()
        {
            var logManager = WebContainerManager.Get<ILogManager>();
            GlobalConfiguration.Configuration.MessageHandlers.Add(
                new BasicAuthenticationMessageHandler(logManager, WebContainerManager.Get<IBasicSecurityService>()));
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();

            if (exception != null)
            {
                var log = WebContainerManager.Get<ILogManager>().GetLog(typeof(WebApiApplication));
                log.Error("Unhandled exception.", exception);
            }
        }
    }
}
