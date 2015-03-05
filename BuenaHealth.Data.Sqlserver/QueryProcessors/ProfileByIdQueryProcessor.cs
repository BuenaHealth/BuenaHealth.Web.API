using BuenaHealth.Data.Entities;
using NHibernate;

namespace BuenaHealth.Data.SqlServer.QueryProcessors
{
    public class ProfileByIdQueryProcessor : IProfileByIdQueryProcessor
    {
        private readonly ISession _session;

        public ProfileByIdQueryProcessor(ISession session)
        {
            _session = session;
        }

        public Profile GetProfile(long profileId)
        {
            var profile = _session.Get<Profile>(profileId);
            return profile;
        }
    }
}
