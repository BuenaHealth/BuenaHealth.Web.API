using System;
using BuenaHealth.Common.Security;

namespace BuenaHealth.Web.Common.Security
{
    public interface IWebUserSession : IUserSession
    {
        string ApiVersionInUser { get; }
        Uri ReqeustUri { get; }
        string HttpRequestMethod { get; }
    }
}
