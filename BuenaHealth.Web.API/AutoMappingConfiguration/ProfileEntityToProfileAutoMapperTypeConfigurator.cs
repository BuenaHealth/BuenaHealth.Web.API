using AutoMapper;
using BuenaHealth.Common.TypeMapping;
using Profile = BuenaHealth.Data.Entities.Profile;

namespace BuenaHealth.Web.API.AutoMappingConfiguration
{
    public class ProfileEntityToProfileAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<Profile, Models.Profile>()
                .ForMember(opt => opt.Links, x => x.Ignore())
                .ForMember(opt => opt.Associates, x => x.ResolveUsing<ProfileAssociatesResolver>());
        }
    }
}