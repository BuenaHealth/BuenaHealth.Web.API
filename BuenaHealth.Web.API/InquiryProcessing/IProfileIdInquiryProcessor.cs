using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.InquiryProcessing
{
    public interface IProfileByIdInquiryProcessor
    {
        Profile GetProfile(long profileId);
    }
}
