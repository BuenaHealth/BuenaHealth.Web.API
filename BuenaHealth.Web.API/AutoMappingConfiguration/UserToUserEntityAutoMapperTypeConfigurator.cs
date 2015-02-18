using AutoMapper;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.AutoMappingConfiguration
{
    public class UserToUserEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<User, Data.Entities.User>()
                .ForMember(opt => opt.Version, x => x.Ignore());
        }
    }
}