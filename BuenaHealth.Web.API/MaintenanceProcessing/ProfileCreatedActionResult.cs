using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public class ProfileCreatedActionResult : IHttpActionResult
    {
        private readonly Profile _createdProfile;
        private readonly HttpRequestMessage _requestMessage;

        public ProfileCreatedActionResult(HttpRequestMessage requestMessage, Profile createdProfile)
        {
            _requestMessage = requestMessage;
            _createdProfile = createdProfile;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute());
        }

        public HttpResponseMessage Execute()
        {
            var responseMessage = _requestMessage.CreateResponse(HttpStatusCode.Created, _createdProfile);
            responseMessage.Headers.Location = LocationLinkCalculator.GetLocationLink(_createdProfile);

            return responseMessage;
        }
    }
}