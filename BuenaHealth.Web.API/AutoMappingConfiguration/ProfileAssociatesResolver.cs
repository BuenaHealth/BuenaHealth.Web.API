using System.Collections.Generic;
using System.Linq;
using BuenaHealth.Common.TypeMapping;
using BuenaHealth.Data.Entities;
using BuenaHealth.Web.Common;
using User = BuenaHealth.Web.API.Models.User;

namespace BuenaHealth.Web.API.AutoMappingConfiguration
{
    public class ProfileAssociatesResolver : AutoMapper.ValueResolver<Profile, List<User>>
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