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
    public class MedicoEspecialidadBLL
    {
        private readonly SysCExpertContext _context;

        #region Singleton
        private readonly static MedicoEspecialidadBLL _instance = new MedicoEspecialidadBLL();

        public static MedicoEspecialidadBLL Current
        {
            get
            {
                return _instance;
            }
        }


        #endregion


        public MedicoEspecialidadBLL()
        {
            _context = new SysCExpertContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }


        public void InsertEspecialidadMedico(MedicoPorEspecialidad medicoEspecialista)
        {
            _context.MedicoPorEspecialidads.Add(medicoEspecialista);
            _context.SaveChanges();
        }
    }
}
