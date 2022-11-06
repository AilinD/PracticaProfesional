using Services.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL
{
    public class RestoreRepository : IRestoreRepository
    {
        #region Singleton
        private readonly static RestoreRepository _instance = new RestoreRepository();

        private string ConString { get; }
        public static RestoreRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private RestoreRepository()
        {

        }
        #endregion
        public void CrearRestore(string databaseName, string path)
        {
            string conn = getConn(databaseName);

            string filePath = BuildrestorePathWithFilename(databaseName, path);

            using (var connection = new SqlConnection(conn))
            {
                var query = String.Format("use master RESTORE DATABASE [{0}] FROM DISK='{1}'", databaseName, path);

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private string BuildrestorePathWithFilename(string databaseName, string save)
        {
            string filename = string.Format("{0}-{1}.bak", databaseName, DateTime.Now.ToString("yyyy-MM-dd"));

            return Path.Combine(save, filename);
        }

        private string getConn(string bd)
        {
            var cadena = "";
            if (bd == "SysCExpert.bak")
            {
                var opc1 = System.Configuration.ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
                cadena = opc1;
            }
            else if (bd == "PatenteFamilia.bak")
            {
                var opc2 = System.Configuration.ConfigurationManager.ConnectionStrings["BackupPath1"].ConnectionString;
                cadena = opc2;
            }
            return cadena;
        }
    }
}
