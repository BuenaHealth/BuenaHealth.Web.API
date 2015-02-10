using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenaHealth.Data.Entities;

namespace BuenaHealth.Data.SqlServer.Mapping
{
    public class UserMap : VersionedClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.UserId);
            Map(x => x.FirstName).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
            Map(x => x.UserName).Not.Nullable();
        }
    }
}
