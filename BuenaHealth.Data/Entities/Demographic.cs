using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Data.Entities
{
    public class Demographic
    {
        public virtual long DemographicId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual Language Language { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual Race Race{ get; set; }
        public virtual Ethnicity Ethnicity { get; set; }
    }
}
