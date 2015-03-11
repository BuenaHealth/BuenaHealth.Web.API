using BuenaHealth.Common;
using BuenaHealth.Common.Logging;
using BuenaHealth.Common.Security;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.QueryProcessors;
using BuenaHealth.Data.SqlServer.Mapping;
using BuenaHealth.Data.SqlServer.QueryProcessors;
using BuenaHealth.Web.API.AutoMappingConfiguration;
using BuenaHealth.Web.API.MaintenanceProcessing;
using BuenaHealth.Web.API.Security;
using BuenaHealth.Web.Common;
using BuenaHealth.Web.Common.Security;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using log4net.Config;
using NHibernate;
using NHibernate.Context;
using Ninject;
using Ninject.Activation;
using Ninject.Web.Common;

namespace BuenaHealth.Web.API.App_Start
{
    public class NinjectConfigurator
    {
        public void Configure(IKernel container)
        {
            AddBindings(container);
        }

        private void AddBindings(IKernel container)
        {
            ConfigureLog4Net(container);
            ConfigureUserSession(container);
            ConfigureNHibernate(container);
            ConfigureAutoMapper(container);
            container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();
            container.Bind<IAddProfileQueryProcessor>().To<AddProfileQueryProcessor>().InRequestScope();
            container.Bind<IAddProfileMaintenanceProcessor>().To<AddProfileMaintenanceProcessor>().InRequestScope();
            container.Bind<IProfileByIdQueryProcessor>().To<ProfileByIdQueryProcessor>().InRequestScope();
            container.Bind<IUpdateProfileStatusQueryProcessor>()
                .To<UpdateProfileStatusQueryProcessor>()
                .InRequestScope();
            container.Bind<IStartProfileWorkflowProcessor>()
                .To<StartProfileWorkflowProcessor>()
                .InRequestScope();
            container.Bind<IBasicSecurityService>().To<BasicSecurityService>().InSingletonScope();
        }

        private void ConfigureLog4Net(IKernel container)
        {
            XmlConfigurator.Configure();

            var logManager = new LogManagerAdapter();

            container.Bind<ILogManager>().ToConstant(logManager);

        }

        private void ConfigureNHibernate(IKernel container)
        {
            var sessionFactory = Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("BuenaHealthDb")))
               .CurrentSessionContext("web")
               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProfileMap>())
               .BuildSessionFactory();

            container.Bind<ISessionFactory>().ToConstant(sessionFactory);
            container.Bind<ISession>().ToMethod(CreateSession).InRequestScope();
            container.Bind<IActionTransactionHelper>().To<ActionTransactionHelper>().InRequestScope();

        }

        private ISession CreateSession(IContext context)
        {
            var sessionFactory = context.Kernel.Get<ISessionFactory>();
            if (!CurrentSessionContext.HasBind(sessionFactory))
            {
                var session = sessionFactory.OpenSession();
                CurrentSessionContext.Bind(session);
            }
            return sessionFactory.GetCurrentSession();
        }

        private void ConfigureUserSession(IKernel container)
        {
            var userSession = new UserSession();
            container.Bind<IUserSession>().ToConstant(userSession).InSingletonScope();
            container.Bind<IWebUserSession>().ToConstant(userSession).InSingletonScope();
        }

        private void ConfigureAutoMapper(IKernel container)
        {
            container.Bind<IAutoMapper>().To<AutoMapperAdapter>().InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
            .To<StatusEntityToStatusAutoMapperTypeConfigurator>()
            .InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
            .To<StatusToStatusEntityAutoMapperTypeConfigurator>()
            .InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
            .To<UserEntityToUserAutoMapperTypeConfigurator>()
            .InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
            .To<UserToUserEntityAutoMapperTypeConfigurator>()
            .InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
            .To<NewProfileToProfileEntityAutoMapperTypeConfiguration>()
            .InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>()
            .To<ProfileEntityToProfileAutoMapperTypeConfigurator>()
            .InSingletonScope();
        }
    }
}