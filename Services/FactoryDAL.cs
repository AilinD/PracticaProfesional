using DAL;
using DAL.GenericRepos;
using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class FactoryDAL
    {
        public static IGenericRepository<Paciente> _pacienteRepository { get; private set; }
        public static IGenericRepository<Medico> _medicoRepository { get; private set; }
        public static IGenericRepository<Estudio> _estudioRepository { get; private set; }

        private static SysEntitiesContext _SysEntitiesContext;
        private static string connectionString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;




        /// <summary>
        /// 
        /// </summary>
        static FactoryDAL()
        {
            _SysEntitiesContext = new SysEntitiesContext(connectionString);
            _pacienteRepository=PatientRepository();
            _medicoRepository = MedicoRepository();
            _estudioRepository = EstudioRepository();
        }
        private static  PatientRepository PatientRepository()
        {
            return new PatientRepository(_SysEntitiesContext);
        }

        private static MedicoRepository MedicoRepository()
        {
            return new MedicoRepository(_SysEntitiesContext);
        }

        private static EstudioRepository EstudioRepository()
        {
            return new EstudioRepository(_SysEntitiesContext);
        }
    }
}