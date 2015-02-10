using System;
using System.Collections.Generic;
using BuenaHealth.Data.Interfaces;

namespace BuenaHealth.Data.Entities
{
    public class Profile : IVersionedEntity
    {
        private readonly IList<User> _users = new List<User>();
        public virtual long ProfileId { get; set; }
        public virtual string Name { get; set; }
        public virtual Status Status { get; set; }
        public virtual DateTime CreatedDateTime { get; set; }
        public virtual User CreatedBy { get; set; }

        public virtual IList<User> Users
        {
            get { return _users; }
        }

        public virtual byte[] Version { get; set; }
    }
}
