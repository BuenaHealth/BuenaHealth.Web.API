using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuenaHealth.Common.Logging;
using log4net;

namespace BuenaHealth.Web.API.Security
{
    public class BasicSecurityService : IBasicSecurityService
    {
        private readonly ILog _log;

        public BasicSecurityService(ILogManager logManager)
        {
            _log = logManager.GetLog(typeof (BasicSecurityService));
        }

        public virtual ISession Session
        {
            get { return WebContainerManager.Get<ISession>();  }
        }

        public bool SetPrincipal(string username, string password)
        {
            var user = GetUser(username);

            IPrincipal principal = null;

            if (user == null || (principal = GetPrincipal(user)) == null)
            {
                _log.DebugFormat("System could not validate user {0} ", username);
                return false;
            }

            Thread.CurrentPrincipal = principal;

            if(HTTPContext.Current != null)


        }

        public bool SetSecurityPrincipal(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}