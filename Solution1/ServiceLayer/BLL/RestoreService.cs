using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public class RestoreService: IRestoreService
    {
        private readonly IRestoreService restoreRepository = new RestoreService();
        #region Singleton
        private readonly static RestoreService _instance = new RestoreService();

        public static RestoreService Current
        {
            get
            {
                return _instance;
            }
        }

        public RestoreService()
        {

        }

        public void RestoreDatabase()
        {
            //  BackupBLL.Current.PerformRestore(dbname, path);
          //  restoreRepository.RestoreDatabase("SysCExpert");
        }

       
    }
}