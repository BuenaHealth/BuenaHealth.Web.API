using System;
using System.Linq;
using BuenaHealth.Common;
using BuenaHealth.Web.API.Models;

namespace BuenaHealth.Web.API.MaintenanceProcessing
{
    public static class LocationLinkCalculator
    {
        public static Uri GetLocationLink(ILinkContaining linkContaining)
        {
            var locationLink = linkContaining.Links.FirstOrDefault(
                x => x.Rel == Constants.CommonLinkRelValues.Self);

            return locationLink == null ? null : new Uri(locationLink.Href);
        }
    }
}