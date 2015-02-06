using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Data.Entities
{
    public class Language
    {
        public virtual long LanguageId { get; set; }
        public virtual string Name { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
