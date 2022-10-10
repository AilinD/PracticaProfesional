using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.Sql.Interfaz
{/// <summary>
/// Interfaz para crear el backup
/// </summary>
    public interface IBackupRepository
    {
        void CrearBackup(string databaseName,string save);
    }
}
