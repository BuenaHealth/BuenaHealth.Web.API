using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public interface IReactivateProfileWorkflowProcessor
    {
        Profile ReactivateProfile(long profileId);
    }
}
