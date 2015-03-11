using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuenaHealth.Common;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.Exceptions;
using BuenaHealth.Data.SqlServer.QueryProcessors;
using BuenaHealth.Web.API.Models;
using Microsoft.Ajax.Utilities;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public class StartProfileWorkflowProcessor : IStartProfileWorkflowProcessor
    {
        private readonly IAutoMapper _autoMapper;
        private readonly IProfileByIdQueryProcessor _profileByIdQueryProcessor;
        private readonly IUpdateProfileStatusQueryProcessor _updateProfileStatusQueryProcessor;
        private IDateTime _dateTime;

        public StartProfileWorkflowProcessor(IProfileByIdQueryProcessor profileByIdQueryProcessor, 
            IUpdateProfileStatusQueryProcessor updateProfileStatusQueryProcessor, IAutoMapper autoMapper, IDateTime dateTime)
        {
            _profileByIdQueryProcessor = profileByIdQueryProcessor;
            _updateProfileStatusQueryProcessor = updateProfileStatusQueryProcessor;
            _autoMapper = autoMapper;
            _dateTime = dateTime;
        }

        public Profile StartProfile(long profileId)
        {
            var profileEntity = _profileByIdQueryProcessor.GetProfile(profileId);

            if (profileEntity == null)
            {
                throw new RootObjectNotFoundException("Profile not found");
            }
            
            //Simulate some logic
            if (profileEntity.Status.Name != "Not Started")
            {
               throw new BusinessRuleViolationException("Incorrect profile status. Expected status of 'Not Started'. ");
            }

            profileEntity.StartDate = _dateTime.UtcNow;
            _updateProfileStatusQueryProcessor.UpdateProfileStatus(profileEntity,"In Progress");

            var profile = _autoMapper.Map<Profile>(profileEntity);

            return profile;

        }
    }
}