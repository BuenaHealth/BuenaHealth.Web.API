using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenaHealth.Data.Entities;

namespace BuenaHealth.Data.SqlServer.QueryProcessors
{
    public interface IUpdateProfileStatusQueryProcessor
    {
        void UpdateProfileStatus(Profile profileToUpdate, string statusName);
    }
}
