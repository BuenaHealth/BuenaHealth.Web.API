using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Data.Entities
{
    public class VitalSign
    {
        public virtual long VitalSignId { get; set; }
        public virtual float Height { get; set; }
        public virtual float Weight { get; set; }
        public virtual int Systolic { get; set; }
        public virtual int Diastolic { get; set; }

        public virtual byte[] Version { get; set; }
    }
}
