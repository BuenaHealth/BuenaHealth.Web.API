using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenaHealth.Core.Models;
using BuenaHealth.Core.Services;

namespace BuenaHealth.Infrastructure.Data
{
    public class BuenaHealthUnitOfWork : DbContext, IUnitOfWork
    {
        private BuenaHealthRepository<Demographics> _demographicsRepository;
        private BuenaHealthRepository<Humans> _humansRepository;
        private BuenaHealthRepository<Notes> _notesRepository;
        private BuenaHealthRepository<VitalSigns> _vitalSignsRepository;

        public DbSet<Demographics> Demographics { get; set; }
        public DbSet<Humans> Humans { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<VitalSigns> VitalSigns { get; set; }

        public IRepository<Demographics> DemographicsRepository 
        {
            get
            {
                if (_demographicsRepository == null)
                {
                    _demographicsRepository = new BuenaHealthRepository<Demographics>(this,Demographics);
                }
                return _demographicsRepository;
            }
        }

        public IRepository<Notes> NotesRepository
        {
            get
            {
                if (_notesRepository == null)
                {
                    _notesRepository = new BuenaHealthRepository<Notes>(this, Notes);
                }
                return _notesRepository;
            }
        }

        public IRepository<VitalSigns> VitalSignsRepository
        {
            get
            {
                if (_vitalSignsRepository == null)
                {
                    _vitalSignsRepository = new BuenaHealthRepository<VitalSigns>(this, VitalSigns);
                }
                return _vitalSignsRepository;
            }
        }

        public IRepository<Humans> HumansRepository
        {
            get
            {
                if (_humansRepository == null)
                {
                    _humansRepository = new BuenaHealthRepository<Humans>(this, Humans);
                }
                return _humansRepository;
            }
        }

        public void Commit()
        {
            this.SaveChanges();
        }
    }
}
