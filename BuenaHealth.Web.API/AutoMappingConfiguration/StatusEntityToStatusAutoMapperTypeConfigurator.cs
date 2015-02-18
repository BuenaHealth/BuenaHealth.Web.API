using AutoMapper;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.Entities;

namespace BuenaHealth.Web.API.AutoMappingConfiguration
{
    public class StatusEntityToStatusAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<Status, Models.Status>();
        }
    }
}