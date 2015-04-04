using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public interface ICompleteProfileWorkflowProcessor
    {
        Profile CompleteProfile(long profileId);
    }
}
