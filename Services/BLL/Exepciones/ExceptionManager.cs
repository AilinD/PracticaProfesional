using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Exepciones
{
    public class ExceptionManager
    {
        #region Singleton
        private readonly static ExceptionManager _instance = new ExceptionManager();

        public static ExceptionManager Current
        {
            get
            {
                return _instance;
            }
        }

        private ExceptionManager()
        {
            //Implement here the initialization code
        }
        #endregion

        public void Handle(BLLException ex)
        {
            if (ex.InnerException is DALException)
            {
                //Si viene de DAL reemplazo el mensaje y lanzo...
                throw new Exception("Error accediendo a base de datos", ex);
            }
            else if (ex.IsBusinessException)
            {
                //Es una excepción de reglas de negocio...
                //Registro y relanzo


                throw ex;
            }
            else if (!ex.IsBusinessException)
            {
                //Es una excepción de BLL no especificada...

                //Registrar la excepción

                throw new Exception("Error de negocio. por favor verifique los datos ingresados", ex);
            }
        }
    }
}
