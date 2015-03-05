using System;
using BuenaHealth.Data.Entities;
using NHibernate;

namespace BuenaHealth.Data.SqlServer.QueryProcessors
{
    public class UpdateProfileStatusQueryProcessor : IUpdateProfileStatusQueryProcessor
    {
        private readonly ISession _session;

        public UpdateProfileStatusQueryProcessor(ISession session)
        {
            _session = session;
        }

        public void UpdateProfileStatus(Profile profileToUpdate, string statusName)
        {
            var status = _session.QueryOver<Status>().Where(x => x.Name == statusName).SingleOrDefault();

            profileToUpdate.Status = status;

            _session.SaveOrUpdate(profileToUpdate);
        }
    }
}
