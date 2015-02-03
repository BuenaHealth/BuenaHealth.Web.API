using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Data.Entities
{
    public class Race
    {
        public virtual long RaceId { get; set; }
        public virtual string Name { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
