using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BuenaHealth.Web.API.Models;
using BuenaHealth.Web.Common.Routing;

namespace BuenaHealth.Web.API.Controllers.V1
{
    [ApiVersionOneRoutePrefix("profiles")]
    public class ProfilesController : ApiController
    {
        [Route("",Name = "AddProfileRoute")]
        [HttpPost]
        public Profile AddProfile(HttpRequestMessage requestMessage, Models.Profile newProfile)
        {
            return new Profile
            {
                Name = "In V1, Profile.Name = " + newProfile.Name
            };
        }
    }
}
