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
        private BuenaHealthRepository<Demographic> _demographicRepository;
        private BuenaHealthRepository<Human> _humanRepository;
        private BuenaHealthRepository<Note> _noteRepository;
        private BuenaHealthRepository<VitalSign> _vitalSignRepository;

        public DbSet<Demographic> Demographics { get; set; }
        public DbSet<Human> Humans { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<VitalSign> VitalSigns { get; set; }

        public BuenaHealthUnitOfWork()
        {
            _demographicRepository = null;
            _humanRepository = null;
            _noteRepository = null;
            _vitalSignRepository = null;
        }

        public IRepository<Demographic> DemographicsRepository 
        {
            get
            {
                if (_demographicRepository == null)
                {
                    _demographicRepository = new BuenaHealthRepository<Demographic>(this,Demographics);
                }
                return _demographicRepository;
            }
        }

        public IRepository<Note> NotesRepository
        {
            get
            {
                if (_noteRepository == null)
                {
                    _noteRepository = new BuenaHealthRepository<Note>(this, Notes);
                }
                return _noteRepository;
            }
        }

        public IRepository<VitalSign> VitalSignsRepository
        {
            get
            {
                if (_vitalSignRepository == null)
                {
                    _vitalSignRepository = new BuenaHealthRepository<VitalSign>(this, VitalSigns);
                }
                return _vitalSignRepository;
            }
        }

        public IRepository<Human> HumanRepository
        {
            get
            {
                if (_humanRepository == null)
                {
                    _humanRepository = new BuenaHealthRepository<Human>(this,Humans);
                }
                return _humanRepository;
            }
        }

        
        public void Commit()
        {
            this.SaveChanges();
        }
    }
}
