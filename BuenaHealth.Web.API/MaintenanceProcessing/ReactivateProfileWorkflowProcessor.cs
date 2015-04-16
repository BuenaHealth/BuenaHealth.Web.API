using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuenaHealth.Common;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.Exceptions;
using BuenaHealth.Data.SqlServer.QueryProcessors;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public class ReactivateProfileWorkflowProcessor : IReactivateProfileWorkflowProcessor
    {
        private readonly IAutoMapper _autoMapper;
        private readonly IProfileByIdQueryProcessor _profileByIdQueryProcessor;
        private readonly IUpdateProfileStatusQueryProcessor _updateProfileStatusQueryProcessor;

        public ReactivateProfileWorkflowProcessor(IProfileByIdQueryProcessor profileByIdQueryProcessor, IUpdateProfileStatusQueryProcessor updateProfileStatusQueryProcessor,
            IAutoMapper autoMapper)
        {
            _profileByIdQueryProcessor = profileByIdQueryProcessor;
            _updateProfileStatusQueryProcessor = updateProfileStatusQueryProcessor;
            _autoMapper = autoMapper;
        }

        public Profile ReactivateProfile(long profileId)
        {
            var profileEntity = _profileByIdQueryProcessor.GetProfile(profileId);
            if (profileEntity == null)
            {
                throw new RootObjectNotFoundException("Profile not found");
            }

            if (profileEntity.Status.Name != "Completed")
            {
                throw new BusinessRuleViolationException("Incorrect profile status. Expected status of 'Completed'");
            }

            profileEntity.CompletedDate = null;
            _updateProfileStatusQueryProcessor.UpdateProfileStatus(profileEntity,"In Progress");

            var profile = _autoMapper.Map<Profile>(profileEntity);
            return profile;

        }
    }
}