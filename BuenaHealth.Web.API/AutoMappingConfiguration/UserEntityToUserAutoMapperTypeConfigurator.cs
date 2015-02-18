using AutoMapper;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.Entities;

namespace BuenaHealth.Web.API.AutoMappingConfiguration
{
    public class UserEntityToUserAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<User, Models.User>()
                .ForMember(opt => opt.Links, x => x.Ignore());
        }
    }
}