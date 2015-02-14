using System.Net.Http;
using System.Web.Http;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.Controllers.V2
{
    [RoutePrefix("api/{apiVersion:apiVersionConstraint(V2)}/profiles")]
    public class ProfilesController : ApiController
    {
        [Route("", Name = "AddProfileRouteV2")]
        [HttpPost]
        public Profile AddProfile(HttpRequestMessage requestMessage, NewProfileV2 newProfile)
        {
            return new Profile
            {
                Name = "In V2, Profile.Name = " + newProfile.Name
            };
        }
    }
}
