using System;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace BuenaHealth.Web.Common.Security
{
    public class UserSession : IWebUserSession
    {
        public string FirstName
        {
            get { return ((ClaimsPrincipal) HttpContext.Current.User).FindFirst(ClaimTypes.GivenName).Value; }
        }

        public string LastName
        {
            get { return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst(ClaimTypes.Surname).Value; }
        }

        public string Username
        {
            get { return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst(ClaimTypes.Name).Value; }
        }

        public bool IsInRole(string roleName)
        {
            return HttpContext.Current.User.IsInRole(roleName);
        }


        public string ApiVersionInUser
        {
            get
            {
                const int versionIndex = 2;
                if (HttpContext.Current.Request.Url.Segments.Count() < versionIndex + 1)
                {
                    return string.Empty;
                }

                var apiVersionInUse = HttpContext.Current.Request.Url.Segments[versionIndex].Replace("/", String.Empty);
                
                return apiVersionInUse;
            }
        }

        public Uri ReqeustUri
        {
            get { return HttpContext.Current.Request.Url; }
        }

        public string HttpRequestMethod
        {
            get { return HttpContext.Current.Request.HttpMethod; }
        }
    }
}
