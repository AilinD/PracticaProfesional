using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BackupBLL
    {
        #region Singleton
        private readonly static BackupBLL _instance = new BackupBLL();

        public static BackupBLL Current
        {
            get
            {
                return _instance;
            }
        }

        private BackupBLL()
        {
            //Implement here the initialization code
        }
        #endregion

        public void CreateBakcup()
        {
            //BackupService
        }
    }
}
