using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    internal class TurnoRepository : IGenericRepository<Turno>
    {
        public void Delete(Turno guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Turno> GetAll(Paciente parameters = null)
        {
            throw new NotImplementedException();
        }

        public Turno GetOne(int? guid)
        {
            throw new NotImplementedException();
        }

        public void Insert(Turno obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Turno obj)
        {
            throw new NotImplementedException();
        }
    }
}
