using DataAccess.BaseProd;
using DataAccess.Interfaces;
using DataAccess.Tools;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paciente = DataAccess.BaseProd.Paciente;

namespace DataAccess.Repo.Sql
{
    public class PacientesRepo : IGenericRepo<Paciente>
    {
        SysCExpertEntities1 context = new SysCExpertEntities1();  
        public void Delete(Guid? guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paciente> GetAll(Paciente parameters = null)
        {

            // return context..ToList();
            throw new NotImplementedException();
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
