using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Web.Common;
using Profile = BuenaHealth.Data.Entities.Profile;
using User = BuenaHealth.Web.API.Models.User;

namespace BuenaHealth.Web.API.AutoMappingConfiguration
{
    public class ProfileAssociatesResolver : ValueResolver<Profile, List<User>>
    {
        public IAutoMapper AutoMapper
        {
            get
            {
                return WebContainerManager.Get<IAutoMapper>();
            }
        }

        protected override List<User> ResolveCore(Profile source)
        {
            return source.Users.Select(x => AutoMapper.Map<User>(x)).ToList();
        }
    }
}