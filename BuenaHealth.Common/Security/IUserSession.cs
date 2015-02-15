namespace BuenaHealth.Common.Security
{
    public interface IUserSession
    {
        string FirstName { get; }
        string LastName { get; }
        string Username { get; }
        bool IsInRole(string roleName);
    }
}