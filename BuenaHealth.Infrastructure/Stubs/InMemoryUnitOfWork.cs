using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenaHealth.Core.Models;
using BuenaHealth.Core.Services;

namespace BuenaHealth.Infrastructure.Stubs
{
    public class InMemoryUnitOfWork : IUnitOfWork
    {
        private readonly InMemoryRepository<Demographic> _demographicRepository;
        private readonly InMemoryRepository<Note> _noteRepository;
        private readonly InMemoryRepository<VitalSign> _vitalSignRepository;
        private readonly InMemoryRepository<Human> _humanRepository;

        private List<Demographic> _demographics;
        private List<Note> _notes;
        private List<VitalSign> _vitalSigns;
        private List<Human> _humans;

        public List<Demographic> Demographics
        {
            get
            {
                if (_demographics == null)
                {
                    _demographics = new List<Demographic>();
                }
                return _demographics;
            }
        }

        public List<Note> Notes
        {
            get
            {
                if (_notes == null)
                {
                    _notes = new List<Note>();
                }
                return _notes;
            }

        }

        public List<VitalSign> VitalSigns
        {
            get
            {
                if (_vitalSigns == null)
                {
                    _vitalSigns = new List<VitalSign>();
                }
                return _vitalSigns;
            }

        }

        public List<Human> Humans
        {
            get
            {
                if (_humans == null)
                {
                    _humans = new List<Human>();
                }
                return _humans;
            }
        }

        public InMemoryUnitOfWork()
        {
            _demographicRepository = new InMemoryRepository<Demographic>(Demographics);
            _noteRepository = new InMemoryRepository<Note>(Notes);
            _vitalSignRepository = new InMemoryRepository<VitalSign>(VitalSigns);
            _humanRepository = new InMemoryRepository<Human>(Humans);
        }

        public IRepository<Demographic> DemographicsRepository
        {
            get { return _demographicRepository; }

        }

        public IRepository<Note> NotesRepository
        {
            get { return _noteRepository; }
        }

        public IRepository<VitalSign> VitalSignsRepository
        {
            get { return _vitalSignRepository; }
        }

        public IRepository<Human> HumanRepository
        {
            get { return _humanRepository; }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
