using System.Net.Http;
using System.Web.Http;
using BuenaHealth.Web.API.Models;
using BuenaHealth.Web.Common;
using BuenaHealth.Web.Common.Routing;

namespace BuenaHealth.Web.API.Controllers.V1
{
    [ApiVersion1RoutePrefix("profiles")]
    [UnitOfWorkActionFilter]
    public class ProfilesController : ApiController
    {
        [Route("",Name = "AddProfileRoute")]
        [System.Web.Http.HttpPost]
        public Profile AddProfile(HttpRequestMessage requestMessage, NewProfile newProfile)
        {
            return new Profile
            {
                Name = "In V1, Profile.Name = " + newProfile.Name
            };
        }
    }
}
