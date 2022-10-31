using DAL.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class MedicoRepository : IGenericRepository<Medico>
    {
        private readonly SysEntitiesContext _context;

        public MedicoRepository(SysEntitiesContext context)
        {
            _context = context;
        }
        public void Delete(Medico guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medico> GetAll(Paciente parameters = null)
        {
            return _context.Medico.ToList();
        }

        public Medico GetOne(int? guid)
        {
            throw new NotImplementedException();
        }

        public void Insert(Medico obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Medico obj)
        {
            throw new NotImplementedException();
        }
    }
}
