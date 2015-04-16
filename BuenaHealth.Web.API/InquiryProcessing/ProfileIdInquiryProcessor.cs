using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.Exceptions;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.InquiryProcessing
{
    public class ProfileIdInquiryProcessor : IProfileByIdInquiryProcessor
    {
        private readonly IAutoMapper _autoMapper;
        private readonly IProfileByIdInquiryProcessor _queryProcessor;

        public ProfileIdInquiryProcessor(IProfileByIdInquiryProcessor queryProcessor, IAutoMapper autoMapper)
        {
            _queryProcessor = queryProcessor;
            _autoMapper = autoMapper;
        }

        public Profile GetProfile(long profileId)
        {
            var profileEntity = _queryProcessor.GetProfile(profileId);
            if (profileId == null)
            {
                throw new RootObjectNotFoundException("Profile not found");
            }

            var profile = _autoMapper.Map<Profile>(profileEntity);
            return profile;
        }
    }
}
