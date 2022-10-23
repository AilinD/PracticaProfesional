using Services.DAL.PatenteDAL;
using Services.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL
{
    public  class LoginService
    {
        public static Sesion GetUsuarioByUserName(string user)
        {
            try
            {
                var call =Usuario_Facade.GetUsuario(user);

                if (call == null)
                {

                }

                return new Sesion() { usuario = call };
                
            }
            catch (Exception ex)
            {
                //LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");
                throw ex;
            }

        }
    }

}
