using AutoMapper;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Web.API.Models;
using Profile = BuenaHealth.Data.Entities.Profile;

namespace BuenaHealth.Web.API.AutoMappingConfiguration
{
    public class NewProfileToProfileEntityAutoMapperTypeConfiguration : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<NewProfile, Profile>()
                .ForMember(opt => opt.Version, x => x.Ignore())
                .ForMember(opt => opt.CreatedBy, x => x.Ignore())
                .ForMember(opt => opt.CreatedDateTime, x => x.Ignore())
                .ForMember(opt => opt.StartDate, x => x.Ignore())
                .ForMember(opt => opt.ProfileId, x => x.Ignore())
                .ForMember(opt => opt.Status, x => x.Ignore())
                .ForMember(opt => opt.Users, x => x.Ignore());
        }
    }
}