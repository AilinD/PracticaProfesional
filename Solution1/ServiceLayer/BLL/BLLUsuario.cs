using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public static class BLLUsuario
    {
        public static ServiceLayer.Domain.PatenteFamilia.Sesion GetUsuarioByUserName(string user)
        {
            try
            {
                var call = DAL.PatenteFamilia.Usuario_Facade.GetUsuario(user);
                return new Sesion() {usuario=call };

            }
            catch (Exception ex)
            {
                //throw new BLLException(ex);
                throw ex;
            }
            
        }
    }
}
