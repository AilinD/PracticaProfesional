using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public  class LogginService : ILoggingService
    {
        #region singleton
        private readonly static LogginService _instance = new LogginService();

        public static LogginService Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        public  Sesion IniciarSesion(string usuario, string pass)
        {
            var user = BLLUsuario.GetUsuarioByUserName(usuario,pass);

            return new Sesion() { usuario = user.usuario};
        }
    }
}
