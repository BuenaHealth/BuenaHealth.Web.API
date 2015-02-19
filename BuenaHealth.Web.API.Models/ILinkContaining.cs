using System.Collections.Generic;

namespace BuenaHealth.Web.API.Models
{
    public interface ILinkContaining
    {
        List<Link> Links { get; set; }
        void AddLink(Link link);
    }
}
