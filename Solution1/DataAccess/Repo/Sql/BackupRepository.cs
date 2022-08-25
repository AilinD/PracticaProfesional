using DataAccess.Repo.Sql.Interfaz;
using System.Data.SqlClient;
using System;
using System.Configuration;
using System.IO;


namespace DataAccess.Repo.Sql
{/// <summary>
/// Clase que implementa la interfaz IBackupRepository 
/// </summary>
    public class BackupRepository : IBackupRepository
    {
        private  string ConString { get; }
        public BackupRepository()
        {
            ConString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
        }
        public void CrearBackup(string databasename)
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

            return Path.Combine(ConfigurationManager.AppSettings.Get("RestorePath"), filename);
        }
    }
}
