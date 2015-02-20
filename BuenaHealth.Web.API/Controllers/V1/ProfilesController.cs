using System.Net.Http;
using System.Web.Http;
using BuenaHealth.Web.API.MaintenanceProcessing;
using BuenaHealth.Web.API.Models;
using BuenaHealth.Web.Common;
using BuenaHealth.Web.Common.Routing;

namespace BuenaHealth.Web.API.Controllers.V1
{
    [ApiVersion1RoutePrefix("profiles")]
    [UnitOfWorkActionFilter]
    public class ProfilesController : ApiController
    {
        private readonly IAddProfileMaintenanceProcessor _addProfileMaintenanceProcessor;

        public ProfilesController(IAddProfileMaintenanceProcessor addProfileMaintenanceProcessor)
        {
            _addProfileMaintenanceProcessor = addProfileMaintenanceProcessor;
        }

        [Route("",Name = "AddProfileRoute")]
        [HttpPost]
        public IHttpActionResult AddProfile(HttpRequestMessage requestMessage, NewProfile newProfile)
        {
            var profile = _addProfileMaintenanceProcessor.AddProfile(newProfile);
            var result = new ProfileCreatedActionResult(requestMessage, profile);

            return result;
        }
    }
}
