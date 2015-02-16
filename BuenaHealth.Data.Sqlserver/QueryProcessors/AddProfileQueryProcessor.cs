using System;
using BuenaHealth.Data.Entities;
using BuenaHealth.Common;
using BuenaHealth.Common.Security;
using BuenaHealth.Data.Entities;
using BuenaHealth.Data.Exceptions;
using BuenaHealth.Data.QueryProcessors;
using NHibernate;
using NHibernate.Util;


namespace BuenaHealth.Data.SqlServer.QueryProcessors
{
    public class AddProfileQueryProcessor : IAddProfileQueryProcessor
    {
        private readonly IDateTime _datetime;
        private readonly ISession _session;
        private readonly IUserSession _userSession;

        public void AddProfile(Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}
