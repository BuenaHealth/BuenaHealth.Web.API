using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public interface IStartProfileWorkflowProcessor
    {
        Profile StartProfile(long profileId);
    }
}
