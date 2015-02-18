using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public interface IAddProfileMaintenanceProcessor
    {
        Profile AddProfile(NewProfile newProfile);
    }
}
