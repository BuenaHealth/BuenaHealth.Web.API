using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BuenaHealth.Common.TypeMapping;

namespace BuenaHealth.Web.API.App_Start
{
    public class AutoMapperConfigurator
    {
        public void Configure(IEnumerable<IAutoMapperTypeConfigurator> autoMapperTypeConfigurations)
        {
            autoMapperTypeConfigurations.ToList()
                .ForEach(x => x.Configure());

            Mapper.AssertConfigurationIsValid();
        }
    }
}