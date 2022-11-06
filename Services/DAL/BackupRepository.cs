using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Services.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL
{
    public class BackupRepository : IBackupRepository
    {
        #region Singleton
        private readonly static BackupRepository _instance = new BackupRepository();

       
        public static BackupRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private BackupRepository()
        {
            
        }
        #endregion


        private IConfiguration _configuration;

        public BackupRepository(IConfiguration configuration)
        {
            _configuration= configuration;
        }
        public void CrearBackup(string databasename, string save)
        {
            string conn = getConn(databasename);

            string filePath = BuildBackupPathWithFilename(databasename, save);

            using (var connection = new SqlConnection(conn))
            {
                var query = String.Format("BACKUP DATABASE [{0}] TO DISK='{1}'", databasename, filePath);

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private string BuildBackupPathWithFilename(string databaseName, string save)
        {
            string filename = string.Format("{0}-{1}.bak", databaseName, DateTime.Now.ToString("yyyy-MM-dd"));

            return Path.Combine(save, filename);
        }

        private string getConn(string bd)
        {
            var cadena="";
            if (bd=="SysCExpert")
            {
                var opc1 =System.Configuration.ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
                cadena = opc1;
            }
            else if(bd== "PatenteFamilia")
            {
                var opc2 = System.Configuration.ConfigurationManager.ConnectionStrings["BackupPath1"].ConnectionString;
                cadena = opc2;
            }
            return cadena;
        }
    }
}