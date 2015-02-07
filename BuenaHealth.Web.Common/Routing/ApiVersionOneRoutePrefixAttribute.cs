using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace BuenaHealth.Web.Common.Routing
{
    public class ApiVersionOneRoutePrefixAttribute : RoutePrefixAttribute
    {
        private const string RouteBase = "api/{apiVersion:apiVersionConstraint(V1)}";
        private const string PrefixRouteBase = RouteBase + "/";

        /// <summary>
        /// Takes API Version and creates URI
        /// </summary>
        /// <param name="routePrefix">API Version URI</param>
        public ApiVersionOneRoutePrefixAttribute(string routePrefix)
            : base(string.IsNullOrWhiteSpace(routePrefix)
             ? RouteBase : PrefixRouteBase + routePrefix)
        {

        }
    }
}
