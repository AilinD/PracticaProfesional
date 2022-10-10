using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repo.Sql.Interfaz;
using System.IO;

namespace DAL.Repo.Sql
{
    public class RestoreRepository :IRestoreRepository
    {

        private string ConString { get; }
        public RestoreRepository()
        {
            ConString = ConfigurationManager.ConnectionStrings["MainConString3"].ConnectionString;
        }
        public void CrearRestore(string databasename,string path)
        {

            using (var connection = new SqlConnection(ConString))
            {
                var query = String.Format("use master RESTORE DATABASE [{0}] FROM DISK='{1}'", databasename, path);

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        //private string BuildRFilename(string databaseName)
        //{
        //    string filename = string.Format("{0}.bak", databaseName);

        //    return  filename;
        //}
    }
}
