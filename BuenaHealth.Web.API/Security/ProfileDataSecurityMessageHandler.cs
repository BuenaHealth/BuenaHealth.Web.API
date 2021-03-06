﻿using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BuenaHealth.Common.Logging;
using BuenaHealth.Common.Security;
using BuenaHealth.Web.API.Models;
using log4net;

namespace BuenaHealth.Web.API.Security
{
    public class ProfileDataSecurityMessageHandler : DelegatingHandler
    {
        private readonly ILog _log;
        private readonly IUserSession _userSession;

        public ProfileDataSecurityMessageHandler(ILogManager logManager, IUserSession userSession)
        {
            _log = logManager.GetLog(typeof(ProfileDataSecurityMessageHandler));
            _userSession = userSession;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            if (CanHandleResponse(response))
            {
                ApplySecurityToResponseData((ObjectContent)response.Content);
            }

            return response;
        }

        public bool CanHandleResponse(HttpResponseMessage response)
        {
            var objectContent = response.Content as ObjectContent;
            var canHandleResponse = objectContent != null && objectContent.ObjectType == typeof(Task);
            return canHandleResponse;
        }

        public void ApplySecurityToResponseData(ObjectContent responseObjectContent)
        {
            var removeSensitiveData = !_userSession.IsInRole(BuenaHealth.Common.Constants.RoleNames.SeniorWorker);

            if (removeSensitiveData)
            {
                _log.DebugFormat("Applying security data masking for user {0}", _userSession.Username);
            }

            ((Profile)responseObjectContent.Value).SetShouldSerializeAssociates(!removeSensitiveData);
        }
    }
}
