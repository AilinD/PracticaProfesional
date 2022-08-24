using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repo.Sql.Interfaz;

namespace DataAccess.Repo.Sql
{
    public class RestoreRepository :IRestoreRepository
    {

        private string ConString { get; }
        public RestoreRepository()
        {
            ConString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
        }
        public void CrearRestore(string databasename)
        {

            string filePath = BuildBackupPathWithFilename(databasename);

            using (var connection = new SqlConnection(ConString))
            {
                var query = String.Format("BACKUP DATABASE [{0}] TO DISK='{1}'", databasename, filePath);

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private string BuildBackupPathWithFilename(string databaseName)
        {
            string filename = string.Format("{0}-{1}.bak", databaseName, DateTime.Now.ToString("yyyy-MM-dd"));

            return Path.Combine(ConfigurationManager.AppSettings.Get("BackupPath"), filename);
        }
    }
}
