using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

            return profile;
        }
    }
}