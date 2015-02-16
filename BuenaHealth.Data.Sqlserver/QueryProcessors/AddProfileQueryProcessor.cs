using System;
using System.Threading.Tasks;
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
            profile.CreatedDateTime = _datetime.UtcNow;
            profile.Status = _session.QueryOver<Status>().Where(x => x.Name == "Not Started").SingleOrDefault();
            profile.CreatedBy = _session.QueryOver<User>().Where(x => x.UserName == _userSession.Username).SingleOrDefault();

            if (profile.Users != null && profile.Users.Any())
            {
                for (var i = 0; i < profile.Users.Count; i++)
                {
                    var user = profile.Users[i];
                    var persistedUser = _session.Get<User>(user.UserId);
                    if (persistedUser == null)
                    {
                        throw new ChildObjectNotFoundException("User not found");
                    }
                    profile.Users[i] = persistedUser;
                }
            }
            _session.SaveOrUpdate(profile);
        }
    }
}
