using System;
using System.Configuration;

[assembly: WebActivator.PostApplicationStartMethod(typeof(BuenaHealth.Web.API.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace BuenaHealth.Web.API.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using BuenaHealth.Core.Services;
    using BuenaHealth.ApplicationServices;
    using BuenaHealth.Infrastructure.Data;
    using BuenaHealth.Infrastructure.Stubs;

    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            //#error Register your services here (remove this line).

            // For instance:
            // container.RegisterWebApiRequest<IUserRepository, SqlUserRepository>();
            // Register your types, for instance:
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["Connected"].ToString()))
            {
                //SQL
                container.RegisterWebApiRequest<IUnitOfWork, BuenaHealthUnitOfWork>();
            }
            else
            {
                //Mock
                container.RegisterWebApiRequest<IUnitOfWork, InMemoryUnitOfWork>();
            }
        }
    }
}