using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BuenaHealth.Common;
using BuenaHealth.Web.API.MaintenanceProcessing;
using BuenaHealth.Web.API.Models;
using BuenaHealth.Web.Common;
using BuenaHealth.Web.Common.Routing;

namespace BuenaHealth.Web.API.Controllers.V1
{
    [ApiVersion1RoutePrefix("")]
    [UnitOfWorkActionFilter]
    [Authorize(Roles = Constants.RoleNames.SeniorWorker)]
    public class ProfileWorkflowController : ApiController
    {
        private readonly IStartProfileWorkflowProcessor _startStartProfileWorkflowProcessor;
        private readonly ICompleteProfileWorkflowProcessor _completeProfileWorkflowProcessor;

        public ProfileWorkflowController(IStartProfileWorkflowProcessor startProfileWorkflowProcessor, ICompleteProfileWorkflowProcessor completeProfileWorkflowProcessor)
        {
            _startStartProfileWorkflowProcessor = startProfileWorkflowProcessor;
            _completeProfileWorkflowProcessor = completeProfileWorkflowProcessor;
        }

        [HttpPost]
        [Authorize(Roles = Constants.RoleNames.SeniorWorker)]
        [Route("profiles/{profileId:long}/activations",Name = "StartProfileRoute")]
        public Profile StartProfile(long profileId)
        {
            var profile = _startStartProfileWorkflowProcessor.StartProfile(profileId);
            return profile;
        }

        [HttpPost]
        [Route("profiles/{profileId:long}/completions", Name = "CompleteProfileRoute")]
        public Profile CompleteProfile(long profileId)
        {
            var profile = _completeProfileWorkflowProcessor.CompleteProfile(profileId);
            return profile;
        }

    }
}