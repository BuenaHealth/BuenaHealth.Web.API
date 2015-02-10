using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Data.Interfaces
{
    public interface IVersionedEntity
    {
        byte[] Version { get; set; }
    }
}
