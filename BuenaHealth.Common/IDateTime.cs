using System;

namespace BuenaHealth.Common
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}
