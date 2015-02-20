using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using BuenaHealth.Common;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.QueryProcessors;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public class AddProfileMaintenanceProcessor : IAddProfileMaintenanceProcessor
    {
        private readonly IAutoMapper _autoMapper;
        private readonly IAddProfileQueryProcessor _queryProcessor;

        public AddProfileMaintenanceProcessor(IAddProfileQueryProcessor queryProcessor, IAutoMapper autoMapper)
        {
            _queryProcessor = queryProcessor;
            _autoMapper = autoMapper;
        }

        public Profile AddProfile(NewProfile newProfile)
        {
            var profileEntity = _autoMapper.Map<Data.Entities.Profile>(newProfile);

            _queryProcessor.AddProfile(profileEntity);

            var profile = _autoMapper.Map<Profile>(profileEntity);

            //TODO: Implement link service
            profile.AddLink(new Link
            {
                Method = HttpMethod.Get.Method,
                Href = "http://localhost:4000/api/v1/profiels/" + profile.ProfileId,
                Rel = Constants.CommonLinkRelValues.Self
            });

            return profile;
        }
    }
}