using DataAccess.Repo.Sql;
using DataAccess.Repo.Sql.Interfaz;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public class RestoreService: IRestoreService
    {
        private readonly IRestoreRepository restoreRepository = new RestoreRepository();
        #region Singleton
        private readonly static RestoreService _instance = new RestoreService();

        public static RestoreService Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        public RestoreService()
        {

        }

        public void RestoreDatabase(string databaseName,string path)
        {
            restoreRepository.CrearRestore(databaseName,path);
        }

       
    }
}