using BuenaHealth.Common;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.Exceptions;
using BuenaHealth.Data.SqlServer.QueryProcessors;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public class CompleteProfileWorkflowProcessor : ICompleteProfileWorkflowProcessor
    {
        private readonly IAutoMapper _autoMapper;
        private readonly IProfileByIdQueryProcessor _profileByIdQueryProcessor;
        private readonly IDateTime _dateTime;
        private readonly IUpdateProfileStatusQueryProcessor _updateProfileStatusQueryProcessor;

        private CompleteProfileWorkflowProcessor(IProfileByIdQueryProcessor profileByIdQueryProcessor, IUpdateProfileStatusQueryProcessor updateProfileStatusQueryProcessor,
            IAutoMapper autoMapper, IDateTime dateTime)
        {
            _autoMapper = autoMapper;
            _profileByIdQueryProcessor = profileByIdQueryProcessor;
            _updateProfileStatusQueryProcessor = updateProfileStatusQueryProcessor;
            _dateTime = dateTime;
        }
        public Profile CompleteProfile(long profileId)
        {
            var profileEntity = _profileByIdQueryProcessor.GetProfile(profileId);

            if (profileEntity == null)
            {
                throw new RootObjectNotFoundException("Profile not found");
            }

            //Simulate Workflow logic
            if (profileEntity.Status.Name != "In Progress")
            {
                throw new BusinessRuleViolationException("Incorrect Profile status. Expected In Progress");
            }

            profileEntity.CompletedDate = _dateTime.UtcNow;
            _updateProfileStatusQueryProcessor.UpdateProfileStatus(profileEntity,"Completed");

            var profile = _autoMapper.Map<Profile>(profileEntity);

            return profile;
        }
    }
}