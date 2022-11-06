using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class EstudioPacienteBLL
    {

        private readonly SysCExpertContext _context;

        #region Singleton
        private readonly static EstudioPacienteBLL _instance = new EstudioPacienteBLL();

        public static EstudioPacienteBLL Current
        {
            get
            {
                return _instance;
            }
        }

       
        #endregion


        public EstudioPacienteBLL()
        {
            _context=new SysCExpertContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }


        public void InsertEstudioPaciente(EstudioPaciente estudioPaciente)
        {
            _context.EstudioPacientes.Add(estudioPaciente);
            _context.SaveChanges();
        }
    }
}
