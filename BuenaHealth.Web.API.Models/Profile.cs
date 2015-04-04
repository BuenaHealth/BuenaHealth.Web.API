using System;
using System.Collections.Generic;

namespace BuenaHealth.Web.API.Models
{
    public class Profile : ILinkContaining
    {
        private List<Link> _links;

        public long? ProfileId { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime StartDate { get; set; }
        public List<User> Associates { get; set; }
        public DateTime CompletedDate { get; set; }

        public List<Link> Links
        {
            get { return _links ?? (_links = new List<Link>()); }
            set { _links = value; }
        }

        public void AddLink(Link link)
        {
            Links.Add(link);
        }
    }
}
