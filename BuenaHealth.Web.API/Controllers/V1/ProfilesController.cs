using System.Net.Http;
using System.Web.Http;
using BuenaHealth.Common;
using BuenaHealth.Web.API.InquiryProcessing;
using BuenaHealth.Web.API.MaintenanceProcessing;
using BuenaHealth.Web.API.Models;
using BuenaHealth.Web.Common;
using BuenaHealth.Web.Common.Routing;

namespace BuenaHealth.Web.API.Controllers.V1
{
    [ApiVersion1RoutePrefix("profiles")]
    [UnitOfWorkActionFilter]
    [Authorize(Roles = Constants.RoleNames.JuniorWorker)]
    public class ProfilesController : ApiController
    {
        private readonly IAddProfileMaintenanceProcessor _addProfileMaintenanceProcessor;
        private readonly IProfileByIdInquiryProcessor _profileByIdInquiryProcessor;

        public ProfilesController(IAddProfileMaintenanceProcessor addProfileMaintenanceProcessor,
            IProfileByIdInquiryProcessor profileByIdInquiryProcessor)
        {
            _addProfileMaintenanceProcessor = addProfileMaintenanceProcessor;
            _profileByIdInquiryProcessor = profileByIdInquiryProcessor;
        }

        [Route("",Name = "AddProfileRoute")]
        [HttpPost]
        [Authorize(Roles =  Constants.RoleNames.Manager)]
        public IHttpActionResult AddProfile(HttpRequestMessage requestMessage, NewProfile newProfile)
        {
            var profile = _addProfileMaintenanceProcessor.AddProfile(newProfile);
            var result = new ProfileCreatedActionResult(requestMessage, profile);

            return result;
        }

        [Route("{profileId:long}", Name = "GetProfileName")]
        public Profile GetProfile(long profileId)
        {
            var profile = _profileByIdInquiryProcessor.GetProfile(profileId);
            return profile;
        }
    }
}
