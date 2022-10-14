using DataAccess.bASEpROD;
using DataAccess.Interfaces;
using DataAccess.Tools;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paciente = DataAccess.bASEpROD.Paciente;

namespace DataAccess.Repo.Sql
{
    public class PacientesRepo : IGenericRepo<Paciente>
    {
        SysCExpertEntities context = new SysCExpertEntities();  
        public void Delete(Guid? guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paciente> GetAll(Paciente parameters = null)
        {

            return context.Pacientes.ToList();
        }

        public Paciente GetOne(Guid? guid)
        {
            throw new NotImplementedException();
        }

        public void Insert(Paciente obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Paciente obj)
        {
            throw new NotImplementedException();
        }
    }
}
