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
    public class MedicoEspecialidadBLL
    {
        private readonly SysEntitiesContext _context;

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
            _context = new SysEntitiesContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }


        public void InsertEspecialidadMedico(MedicoEspecialista medicoEspecialista)
        {
            _context.MedicoPorEspecialidad.Add(medicoEspecialista);
            _context.SaveChanges();
        }
    }
}
