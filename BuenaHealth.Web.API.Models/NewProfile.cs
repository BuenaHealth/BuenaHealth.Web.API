using System.Collections.Generic;

namespace BuenaHealth.Web.API.Models
{
    public class NewProfile
    {
        public string Name { get;set;}
        public List<User> Users { get; set; }
    }
}
