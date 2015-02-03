using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Data.Entities
{
    public class Note
    {
        public virtual long NoteId { get; set; }
        public virtual string Summmary { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
