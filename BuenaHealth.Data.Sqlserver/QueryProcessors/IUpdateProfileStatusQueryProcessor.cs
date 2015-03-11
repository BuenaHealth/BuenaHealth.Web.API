using BuenaHealth.Data.Entities;

namespace BuenaHealth.Data.SqlServer.QueryProcessors
{
    public interface IUpdateProfileStatusQueryProcessor
    {
        void UpdateProfileStatus(Profile profileToUpdate, string statusName);
    }
}
