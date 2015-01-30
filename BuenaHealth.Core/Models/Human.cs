using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Core.Models
{
    public class Human
    {
        public int HumanId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Demographic Demographic { get; set; }
        public ICollection<VitalSign> VitalSigns { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
