using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.Sql.Interfaz
{
    public interface IRestoreRepository
    {
        void CrearRestore(string databaseName,string path);
    }
}
