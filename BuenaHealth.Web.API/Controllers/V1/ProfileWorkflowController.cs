using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BuenaHealth.Web.API.MaintenanceProcessing;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.Controllers.V1
{
    public class ProfileWorkflowController : ApiController
    {
        private readonly IStartProfileWorkflowProcessor _startStartProfileWorkflowProcessor;

        public ProfileWorkflowController(IStartProfileWorkflowProcessor startProfileWorkflowProcessor)
        {
            _startStartProfileWorkflowProcessor = startProfileWorkflowProcessor;
        }

        public Profile StartProfile(long profileId)
        {
            var profile = _startStartProfileWorkflowProcessor.StartProfile(profileId);
            return profile;
        }

    }
}