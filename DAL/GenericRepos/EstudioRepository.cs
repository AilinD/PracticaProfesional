using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class EstudioRepository : IGenericRepository<Estudio>
    {
        private readonly SysEntitiesContext _context;

        public EstudioRepository(SysEntitiesContext context)
        {
            _context = context;
        }
        public void Delete(Estudio guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estudio> GetAll(Paciente parameters = null)
        {
            throw new NotImplementedException();
        }

        public Estudio GetOne(int? guid)
        {
            throw new NotImplementedException();
        }

        public void Insert(Estudio obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Estudio obj)
        {
            throw new NotImplementedException();
        }
    }
}
