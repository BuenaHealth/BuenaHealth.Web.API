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
        private BuenaHealthRepository<Demographic> _demographicsRepository;
        private BuenaHealthRepository<Human> _humansRepository;
        private BuenaHealthRepository<Note> _notesRepository;
        private BuenaHealthRepository<VitalSign> _vitalSignsRepository;

        public DbSet<Demographic> Demographics { get; set; }
        public DbSet<Human> Humans { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<VitalSign> VitalSigns { get; set; }

        public IRepository<Demographic> DemographicsRepository 
        {
            get
            {
                if (_demographicsRepository == null)
                {
                    _demographicsRepository = new BuenaHealthRepository<Demographic>(this,Demographics);
                }
                return _demographicsRepository;
            }
        }

        public IRepository<Note> NotesRepository
        {
            get
            {
                if (_notesRepository == null)
                {
                    _notesRepository = new BuenaHealthRepository<Note>(this, Notes);
                }
                return _notesRepository;
            }
        }

        public IRepository<VitalSign> VitalSignsRepository
        {
            get
            {
                if (_vitalSignsRepository == null)
                {
                    _vitalSignsRepository = new BuenaHealthRepository<VitalSign>(this, VitalSigns);
                }
                return _vitalSignsRepository;
            }
        }

        public IRepository<Human> HumansRepository
        {
            get
            {
                if (_humansRepository == null)
                {
                    _humansRepository = new BuenaHealthRepository<Human>(this, Humans);
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
