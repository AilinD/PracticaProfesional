
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
    public class BackupService : IBackupService
    {
        private readonly IBackupRepository backupRepository = new BackupRepository();
        #region Singleton
        private readonly static BackupService _instance = new BackupService();

        public static BackupService Current
        {
            get
            {
                return _instance;
            }
        }

        public BackupService()
        {
            //Implement here the initialization code
        }
        #endregion
        public void CrearBackup(string databaseName, string save)
        {
            
            backupRepository.CrearBackup(databaseName, save);
            
        }
    }
}
