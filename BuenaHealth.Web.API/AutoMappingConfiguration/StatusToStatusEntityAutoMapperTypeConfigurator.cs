using AutoMapper;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.AutoMappingConfiguration
{
    public class StatusToStatusEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<Status,Data.Entities.Status>()
                .ForMember(opt => opt.Version, x => x.Ignore());
        }
    }
}