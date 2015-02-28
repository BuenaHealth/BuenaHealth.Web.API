namespace BuenaHealth.Web.API.Security
{
    public interface IBasicSecurityService
    {
        bool SetSecurityPrincipal(string username, string password);
    }
}
