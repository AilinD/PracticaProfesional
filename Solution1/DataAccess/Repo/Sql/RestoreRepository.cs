using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repo.Sql.Interfaz;
using System.IO;

namespace DataAccess.Repo.Sql
{
    public class RestoreRepository :IRestoreRepository
    {

        private string ConString { get; }
        public RestoreRepository()
        {
            ConString = ConfigurationManager.ConnectionStrings["MainConString4"].ConnectionString;
        }
        public void CrearRestore(string databasename)
        {

            string filePath = BuildRestorePathWithFilename(databasename);
            //string filename = string.Format("{0}-{1}.bak", databasename);

            using (var connection = new SqlConnection(ConString))
            {
                var query = String.Format("use master RESTORE DATABASE [{0}] FROM DISK='{1}'", databasename, filePath);

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private string BuildRestorePathWithFilename(string databaseName)
        {
            string filename = string.Format("{0}.bak", databaseName);

            return Path.Combine(ConfigurationManager.AppSettings.Get("RestorePath"), filename);
        }
    }
}
