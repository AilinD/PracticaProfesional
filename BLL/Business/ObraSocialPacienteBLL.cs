using DAL;
using DAL.Models;
//using DAL.Models;
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
        private readonly SysCExpertContext _context;

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
            _context = new SysCExpertContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }


        public void InsertOsPaciente(ObraSocialPaciente OsPaciente)
        {
            _context.ObraSocialPacientes.Add(OsPaciente);
            _context.SaveChanges();
        }
    }
}
