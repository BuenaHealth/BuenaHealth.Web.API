using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenaHealth.Core.Models;

namespace BuenaHealth.Core.Services
{
    public interface IUnitOfWork
    {
        IRepository<Demographics> DemographicsRepository { get; }
        IRepository<Notes> NotesRepository { get; }
        IRepository<VitalSigns> VitalSignsRepository { get; }
    }
}
