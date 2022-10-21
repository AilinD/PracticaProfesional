using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Services.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL
{
    public class BackupRepository : IBackupRepository
    {

        private IConfiguration _configuration;

        public BackupRepository(IConfiguration configuration)
        {
            _configuration= configuration;
        }
        public void CrearBackup(string databasename, string save)
        {

            string filePath = BuildBackupPathWithFilename(databasename, save);

            using (var connection = new SqlConnection(_configuration.GetConnectionString("BackupPath")))
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
    }
}