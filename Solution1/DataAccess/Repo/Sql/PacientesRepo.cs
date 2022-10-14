using DataAccess.Interfaces;
using DataAccess.Tools;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo.Sql
{
    public class PacientesRepo : IGenericRepo<Paciente>
    {
        public void Delete(Guid? guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paciente> GetAll(Paciente parameters = null)
        {
            // yield return SqlHelper.ExecuteNonQuery(string.Format("Select * from Paciente")), System.Data.CommandType.Text ;
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
