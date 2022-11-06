using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class ObraSocialPacienteBLL
    {
        private readonly SysEntitiesContext _context;

        #region Singleton
        private readonly static ObraSocialPacienteBLL _instance = new ObraSocialPacienteBLL();

        public static ObraSocialPacienteBLL Current
        {
            get
            {
                return _instance;
            }
        }


        #endregion


        public ObraSocialPacienteBLL()
        {
            _context = new SysEntitiesContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }


        public void InsertOsPaciente(ObraSocial_Paciente OsPaciente)
        {
            _context.ObraSocialPaciente.Add(OsPaciente);
            _context.SaveChanges();
        }
    }
}
