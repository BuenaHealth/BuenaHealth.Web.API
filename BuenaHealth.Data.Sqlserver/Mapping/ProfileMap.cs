using BuenaHealth.Data.Entities;
using FluentNHibernate.Mapping;

namespace BuenaHealth.Data.SqlServer.Mapping
{
    public class ProfileMap : VersionedClassMap<Profile>
    {
        public ProfileMap()
        {
            Id(x => x.ProfileId);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.CreatedDateTime).Not.Nullable();
            References(x => x.Status, "StatusId");
            References(x => x.CreatedBy, "CreatedUserId");
            HasManyToMany(x => x.Users)
                .Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
                .Table("ProfileUser")
                .ParentKeyColumn("ProfileId")
                .ChildKeyColumn("UserId");

        }
    }
}
