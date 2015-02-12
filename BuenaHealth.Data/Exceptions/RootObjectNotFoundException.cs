using System;

namespace BuenaHealth.Data.Exceptions
{
    [Serializable]
    public class RootObjectNotFoundException : Exception
    {
        public RootObjectNotFoundException(string message)
            : base(message)
        {
        }
    }
}
