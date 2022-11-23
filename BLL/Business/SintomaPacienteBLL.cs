using DAL.Models;
using Services.BLL.Exepciones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class SintomaPacienteBLL
    {
        private readonly SysCExpertContext _context;

        #region Singleton
        private readonly static SintomaPacienteBLL _instance = new SintomaPacienteBLL();

        public static SintomaPacienteBLL Current
        {
            get
            {
                return _instance;
            }
        }


        #endregion


        public SintomaPacienteBLL()
        {
            _context = new SysCExpertContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }

        public void InsertSintomaPaciente(SintomaPaciente sintomaPaciente)
        {
            try
            {
                _context.SintomaPacientes.Add(sintomaPaciente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                throw;
            }

        }

    }
}
