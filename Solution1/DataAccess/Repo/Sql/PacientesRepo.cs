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
        SysEntitiesContext context = new SysEntitiesContext();  
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
            context.Paciente.Add(obj);
            context.SaveChanges();

            throw new NotImplementedException();
        }

        public void Update(Paciente obj)
        {
            throw new NotImplementedException();
        }
    }
}
