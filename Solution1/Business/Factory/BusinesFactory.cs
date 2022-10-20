using DataAccess.Interfaces;
using DataAccess.Repo.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Factory
{
    public static class BusinesFactory
    {

        public static IGenericRepo<DataAccess.BaseProd.Paciente> GenericRepo()
        {
            return new PacientesRepo();
        }
           
    }
}
