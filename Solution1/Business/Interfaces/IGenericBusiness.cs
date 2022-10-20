using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IGenericBusiness<T> where T : class
    {
        void Create(T obj);
        void Delete(T obj);
        void Update(T obj);
        List<T> GetAll();
    }
}
