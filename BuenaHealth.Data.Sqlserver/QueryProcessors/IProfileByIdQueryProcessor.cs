using BuenaHealth.Data.Entities;

namespace BuenaHealth.Data.SqlServer.QueryProcessors
{
    public interface IProfileByIdQueryProcessor
    {
        Profile GetProfile(long profileId);
    }
}
