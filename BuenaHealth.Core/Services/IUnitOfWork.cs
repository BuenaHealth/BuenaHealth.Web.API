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
        IRepository<Demographic> DemographicsRepository { get; }
        IRepository<Note> NotesRepository { get; }
        IRepository<VitalSign> VitalSignsRepository { get; }
        IRepository<Human> HumanRepository { get; }
        void Commit();
    }
}
