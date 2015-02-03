using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Data.Entities
{
    public class Demographic
    {
        public virtual int DemographicId { get; set; }
        public virtual string Language { get; set; }
        public virtual string Sex { get; set; }
        public virtual Race Race{ get; set; }
        public virtual Ethnicity Ethnicity { get; set; }
    }
}
