using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BuenaHealth.Common.TypeMapping;

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