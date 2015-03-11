using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Common
{
    [Serializable]
    public class BusinessRuleViolationException : Exception
    {
        public BusinessRuleViolationException(string incorrectProfileStatus)
            : base(incorrectProfileStatus)
        {
        }
    }
}
