using ServiceLayer.Servicios.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL.Log
{
    internal class ArchivoLog : ILog
    {
        //private ILo
        public void GuardarLog(Servicios.Log.log log)
        {
            throw new NotImplementedException();
        }

        public List<Servicios.Log.log> listarLogs()
        {
        //    try
        //    {
        //        if (ArchivoLog)
        //        {

        //        }
        //    }catch(Exception ex)
        //    {
        //        return ex;
        //    }

         List<log> lista = new List<log>();
        return  lista;
         }
    }
}
