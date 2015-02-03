using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Data.Entities
{
    public class Profile
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
