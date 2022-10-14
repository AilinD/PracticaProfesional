using Microsoft.SqlServer.Management.XEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        
        
          /// <summary>
            /// Inserta un objeto en el repositorio.
            /// </summary>
            /// <param name="obj"></param>
            void Insert( T obj);

            /// <summary>
            /// Actualiza un registro en el repositorio.
            /// </summary>
            /// <param name="obj"></param>
            void Update(T obj);

            /// <summary>
            /// Obtiene todos los registros del repositorio.
            /// </summary>
            /// <returns></returns>
            IEnumerable<T> GetAll(T parameters = null);

            /// <summary>
            /// Obtiene un registro del repositorio.
            /// </summary>
            /// <param name="guid"></param>
            /// <returns></returns>
            T GetOne(Guid? guid);

            /// <summary>
            /// Elimina un registro del repositorio.
            /// </summary>
            /// <param name="guid"></param>
            void Delete(Guid? guid);
        
    }
}
